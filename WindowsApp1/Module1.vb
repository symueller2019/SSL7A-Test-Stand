'*************************************
'for Text File Write
Imports System
Imports System.IO
Imports System.Text
'*************************************

Module Module1
    'Public Class Module1 - DO NOT HAVE CLASS IN MODULE
    'Inherits System.Windows.Forms.Form

    '*** Create a new MccBoard object for Board 0 / relays 1 - 24 ***
    Public DaqBoard As MccDaq.MccBoard = New MccDaq.MccBoard(0)

    Public PortType As Integer
    Public PortNum As MccDaq.DigitalPortType
    Public PortBNum As MccDaq.DigitalPortType
    Public PortANum As MccDaq.DigitalPortType
    Public PortCNum As MccDaq.DigitalPortType

    Public PortCLNum As MccDaq.DigitalPortType
    Public PortCHNum As MccDaq.DigitalPortType

    Public NumPorts, NumBits, MaxPortVal As Integer
    Public ProgAbility As Integer
    Public Direction As MccDaq.DigitalPortDirection


    '*** Create a new MccBoard object for Board 1 relays 25 - 48 ***
    Public DaqBoard1 As MccDaq.MccBoard = New MccDaq.MccBoard(1)

    Public PortType1 As Integer
    Public PortNum1 As MccDaq.DigitalPortType
    Public PortBNum1 As MccDaq.DigitalPortType
    Public PortANum1 As MccDaq.DigitalPortType
    Public PortCNum1 As MccDaq.DigitalPortType

    Public PortCLNum1 As MccDaq.DigitalPortType
    Public PortCHNum1 As MccDaq.DigitalPortType

    Public NumPorts1, NumBits1, MaxPortVal1 As Integer
    Public ProgAbility1 As Integer
    Public Direction1 As MccDaq.DigitalPortDirection


    '*** Create a new MccBoard object for Board 2 relays 49 - 72 ***
    Public DaqBoard2 As MccDaq.MccBoard = New MccDaq.MccBoard(2)

    Public PortType2 As Integer
    Public PortNum2 As MccDaq.DigitalPortType
    Public PortBNum2 As MccDaq.DigitalPortType
    Public PortANum2 As MccDaq.DigitalPortType
    Public PortCNum2 As MccDaq.DigitalPortType

    Public PortCLNum2 As MccDaq.DigitalPortType
    Public PortCHNum2 As MccDaq.DigitalPortType

    Public NumPorts2, NumBits2, MaxPortVal2 As Integer
    Public ProgAbility2 As Integer
    Public Direction2 As MccDaq.DigitalPortDirection

    Public Sub FileWriteCRLF()
        Dim w As StreamWriter

        w = File.AppendText(TestResultFilename)
        w.Write(vbCrLf)
        w.Close()
    End Sub

    Public Sub FileWrite(WriteData As String)
        Dim w As StreamWriter

        w = File.AppendText(TestResultFilename)
        'w = File.AppendText("C:\temp\test.txt")
        w.Write(WriteData)
        w.Write(vbCrLf)
        w.Close()
    End Sub

    Public Sub FileWriteNoCrLf(WriteData As String)
        Dim w As StreamWriter

        w = File.AppendText(TestResultFilename)
        w.Write(WriteData)
        'w.Write(vbCrLf)
        w.Close()
    End Sub

    Public Sub DaqSetup()
        Dim PortName As String
        Dim FirstBit As Integer
        Dim ULStat As MccDaq.ErrorInfo
        Dim DataValue As UInt16
        InitUL()    'initiate error handling, etc

        ''Canned Shit
        ''determine if digital port exists, its capabilities, etc
        'PortType = PORTOUT
        '    NumPorts = FindPortsOfType(DaqBoard, PortType, ProgAbility, PortNum, NumBits, FirstBit)

        '' BM mod 3/19/2019
        'PortNum = MccDaq.DigitalPortType.FirstPortA
        ''PortBNum = MccDaq.DigitalPortType.FirstPortB

        'If NumPorts < 1 Then

        '    Else
        '        ' if programmable, set direction of port to output
        '        ' configure the first port for digital output
        '        '  Parameters:
        '        '    PortNum        :the output port
        '        '    Direction      :sets the port for input or output

        '        If ProgAbility = DigitalIO.PROGPORT Then
        '            Direction = MccDaq.DigitalPortDirection.DigitalOut
        '            ULStat = DaqBoard.DConfigPort(PortNum, Direction)
        '            If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        '        End If
        '    PortName = PortNum.ToString

        'End If

        'My Shit
        '*** DAQBoard0 ***
        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortB, direction:=MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortBNum = MccDaq.DigitalPortType.FirstPortB

        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortANum = MccDaq.DigitalPortType.FirstPortA

        'ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortC, MccDaq.DigitalPortDirection.DigitalOut)
        'If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        'PortCNum = MccDaq.DigitalPortType.FirstPortC

        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortCL, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCLNum = MccDaq.DigitalPortType.FirstPortCL

        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortCH, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCHNum = MccDaq.DigitalPortType.FirstPortCH

        'Turn off Outputs
        DataValue = 255
        'PortATest
        ULStat = DaqBoard.DOut(PortANum, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'PortBTest()
        ULStat = DaqBoard.DOut(PortBNum, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'Turn off PortC low & high Outputs
        DataValue = 15
        ULStat = DaqBoard.DOut(PortCLNum, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        ULStat = DaqBoard.DOut(PortCHNum, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop


        '*** DAQBoard1 ***
        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortANum1 = MccDaq.DigitalPortType.FirstPortA

        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortB, direction:=MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortBNum1 = MccDaq.DigitalPortType.FirstPortB

        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortCL, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCLNum1 = MccDaq.DigitalPortType.FirstPortCL

        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortCH, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCHNum1 = MccDaq.DigitalPortType.FirstPortCH

        'Turn off Outputs
        DataValue = 255

        'PortATest
        ULStat = DaqBoard1.DOut(PortANum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'PortBTest()
        ULStat = DaqBoard1.DOut(PortBNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'Turn off PortC low & high Outputs
        DataValue = 15
        ULStat = DaqBoard1.DOut(PortCLNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        ULStat = DaqBoard1.DOut(PortCHNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop


        '*** DAQBoard2 ***
        ULStat = DaqBoard2.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortANum2 = MccDaq.DigitalPortType.FirstPortA

        ULStat = DaqBoard2.DConfigPort(MccDaq.DigitalPortType.FirstPortB, direction:=MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortBNum2 = MccDaq.DigitalPortType.FirstPortB

        ULStat = DaqBoard2.DConfigPort(MccDaq.DigitalPortType.FirstPortCL, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCLNum2 = MccDaq.DigitalPortType.FirstPortCL

        ULStat = DaqBoard2.DConfigPort(MccDaq.DigitalPortType.FirstPortCH, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCHNum2 = MccDaq.DigitalPortType.FirstPortCH

        'Turn off Outputs
        DataValue = 255

        'PortATest
        ULStat = DaqBoard2.DOut(PortANum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'PortBTest()
        ULStat = DaqBoard2.DOut(PortBNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        'Turn off PortC low & high Outputs
        DataValue = 15
        ULStat = DaqBoard2.DOut(PortCLNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        ULStat = DaqBoard2.DOut(PortCHNum1, DataValue)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

    End Sub


#Region "Universal Library Initialization - Expand this region to change error handling, etc."

    Public Sub InitUL()

        Dim ULStat As MccDaq.ErrorInfo

        ' declare revision level of Universal Library

        ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)

        ' Initiate error handling
        '  activating error handling will trap errors like
        '  bad channel numbers and non-configured conditions.
        '  Parameters:
        '    MccDaq.ErrorReporting.PrintAll :all warnings and errors encountered will be printed
        '    MccDaq.ErrorHandling.StopAll   :if any error is encountered, the program will stop


        ReportError = MccDaq.ErrorReporting.PrintAll
        HandleError = MccDaq.ErrorHandling.StopAll
        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            Stop
        End If

    End Sub

#End Region

    'End Class

    'Board 0 Output Subroutines
    Public Sub PortATest(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1

        ULStat = DaqBoard.DOut(PortANum, DataValue)

    End Sub

    Public Sub PortBTest(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard.DOut(PortBNum, DataValue)
    End Sub

    Public Sub PortCLTest(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard.DOut(PortCLNum, DataValue)
    End Sub

    Public Sub PortCHTest(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard.DOut(PortCHNum, DataValue)
    End Sub




    'Board 1 Output Subroutines
    Public Sub PortATest1(ByVal DataValue1)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1

        ULStat = DaqBoard1.DOut(PortANum1, DataValue1)

    End Sub

    Public Sub PortBTest1(ByVal DataValue1)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard1.DOut(PortBNum1, DataValue1)
    End Sub

    Public Sub PortCLTest1(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard1.DOut(PortCLNum1, DataValue)
    End Sub

    Public Sub PortCHTest1(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard1.DOut(PortCHNum1, DataValue)
    End Sub




    'Board 2 Output Subroutines
    Public Sub PortATest2(ByVal DataValue1)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1

        ULStat = DaqBoard2.DOut(PortANum2, DataValue1)

    End Sub

    Public Sub PortBTest2(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard2.DOut(PortBNum2, DataValue)
    End Sub

    Public Sub PortCLTest2(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard2.DOut(PortCLNum2, DataValue)
    End Sub

    Public Sub PortCHTest2(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard2.DOut(PortCHNum2, DataValue)
    End Sub

    Public Sub PortCTest2(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard2.DOut(PortCNum2, DataValue)
    End Sub

End Module
