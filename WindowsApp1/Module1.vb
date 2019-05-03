'*************************************
'for Text File Write
Imports System
Imports System.IO
Imports System.Text
'*************************************

Module Module1
    'Public Class Module1 - DO NOT HAVE CLASS IN MODULE
    'Inherits System.Windows.Forms.Form

    'Create a new MccBoard object for Board 0
    Public DaqBoard As MccDaq.MccBoard = New MccDaq.MccBoard(0)

    Public PortType As Integer
    Public PortNum As MccDaq.DigitalPortType
    Public PortBNum As MccDaq.DigitalPortType
    Public PortANum As MccDaq.DigitalPortType
    Public PortCNum As MccDaq.DigitalPortType
    Public NumPorts, NumBits, MaxPortVal As Integer
    Public ProgAbility As Integer
    Public Direction As MccDaq.DigitalPortDirection

    'Create a new MccBoard object for Board 1
    Public DaqBoard1 As MccDaq.MccBoard = New MccDaq.MccBoard(1)

    Public PortType1 As Integer
    Public PortNum1 As MccDaq.DigitalPortType
    Public PortBNum1 As MccDaq.DigitalPortType
    Public PortANum1 As MccDaq.DigitalPortType
    Public PortCNum1 As MccDaq.DigitalPortType
    Public NumPorts1, NumBits1, MaxPortVal1 As Integer
    Public ProgAbility1 As Integer

    Public Direction1 As MccDaq.DigitalPortDirection



    Public Sub FileWrite(WriteData As String)
        Dim w As StreamWriter

        w = File.AppendText("C:\temp\test.txt")
        w.Write(WriteData)
        w.Write(vbCrLf)
        w.Close()
    End Sub

    Public Sub FileWriteNoCrLf(WriteData As String)
        Dim w As StreamWriter

        w = File.AppendText("C:\temp\test.txt")
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
        'DAQBoard0
        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortB, direction:=MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortBNum = MccDaq.DigitalPortType.FirstPortB

        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortANum = MccDaq.DigitalPortType.FirstPortA

        ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortC, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCNum = MccDaq.DigitalPortType.FirstPortC

        'Turn off Outputs
        DataValue = 5
        PortATest(DataValue)


        'DAQBoard1
        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortB, direction:=MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortBNum1 = MccDaq.DigitalPortType.FirstPortB

        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortANum1 = MccDaq.DigitalPortType.FirstPortA

        ULStat = DaqBoard1.DConfigPort(MccDaq.DigitalPortType.FirstPortC, MccDaq.DigitalPortDirection.DigitalOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
        PortCNum1 = MccDaq.DigitalPortType.FirstPortC
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

    Public Sub PortCTest(ByVal DataValue)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard.DOut(PortCNum, DataValue)
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

    Public Sub PortCTest1(ByVal DataValue1)
        'Form1.btnHigh.BackColor = Color.Black

        Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        '    DataValue = 1
        'ULStat = DaqBoard.DOut(PortNum, DataValue)
        ULStat = DaqBoard1.DOut(PortCNum1, DataValue1)
    End Sub
End Module
