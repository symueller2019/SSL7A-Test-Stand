Module Module_FileRead
    'control flag
    Public blnFormHold As Boolean
    'arrays to hold Rated Load Configuration info from Configuration text file
    Public LPF_Res(50) As String
    Public LPF_Cap(50) As String
    Public HPF_Res(50) As String
    Public WattageSelection(50) As String
    'arrays to hold Min Load Configuration info from Configuration text file
    Public MinLPF_Res(50) As String
    Public MinLPF_Cap(50) As String
    Public MinHPF_Res(50) As String
    Public MinWattageSelection(50) As String
    'arrays to hold Overload Configuration info from Configuration text file
    Public OVLDLPF_Res(50) As String
    Public OVLDLPF_Cap(50) As String
    Public OVLDWattageSelection(50) As String

    'arrays to hold Rated Relay address
    Public Index As Integer
    Public LPF_ResRelays(10) As String
    Public LPF_CapRelays(10) As String
    Public HPF_ResRelays(10) As String
    'arrays to hold Min Relay address
    Public MinIndex As Integer
    Public MinLPF_ResRelays(10) As String
    Public MinLPF_CapRelays(10) As String
    Public MinHPF_ResRelays(10) As String
    'arrays to hold Overload Relay address
    Public OVLDIndex As Integer
    'Public MinIndex As Integer - same as Rated Index
    Public OVLDLPF_ResRelays(10) As String
    Public OVLDLPF_CapRelays(10) As String

    'Config file locations - read from Configuration text file
    Public FileLoc_Config As String
    Public strTest_File_DirectoryLocation As String
    Public FileLoc_WattSelect As String
    Public FileLoc_WattsToRelayLPFRes As String
    Public FileLoc_WattsToRelayLPFCap As String
    Public FileLoc_WattsToRelayHPFRes As String
    'Config file locations Min - read from Configuration text file
    Public FileLoc_MinWattSelect As String
    Public FileLoc_MinWattsToRelayLPFRes As String
    Public FileLoc_MinWattsToRelayLPFCap As String
    Public FileLoc_MinWattsToRelayHPFRes As String
    'Config file locations Overload - read from Configuration text file
    Public FileLoc_OVLDWattSelect As String
    Public FileLoc_OVLDWattsToRelayLPFRes As String
    Public FileLoc_OVLDWattsToRelayLPFCap As String
    'Config file locations for ON & OFF State Relays - read from Configuration text file
    Public FileLoc_ON_State_Relays As String
    Public FileLoc_OFF_State_Relays As String
    'Test Results Filename
    Public TestResultFilename As String
    'Relay Mask registers
    'make public so each test can control
    'Save Port A & B Image - Boards 1,2 
    Public Bd0_PortASave As UInt16 = 255 : Public Bd0_PortBSave As UInt16 = 255
    Public Bd1_PortASave As UInt16 = 255 : Public Bd1_PortBSave As UInt16 = 255
    Public Bd2_PortASave As UInt16 = 255 : Public Bd2_PortBSave As UInt16 = 255
    'Save PortC Image - Boards 1,2
    Public Bd0_PortCLSave As UInt16 = 15 : Public Bd0_PortCHSave As UInt16 = 15
    Public Bd1_PortCLSave As UInt16 = 15 : Public Bd1_PortCHSave As UInt16 = 15
    Public Bd2_PortCLSave As UInt16 = 15 : Public Bd2_PortCHSave As UInt16 = 15
    'Equates for Load - Relay Control
    Public ShuntRelay As String() = {"Used To Shunt Dimmer", 2}
    Public PwrRelay As String() = {"Main AC disconnect for DUT", 1}





    Public Sub Read_Text_Files()
        'Read in all Wattage selections available in test - get total # of wattage test values available
        '-for each wattage selection there is a corresponding LPF Res & Cap /HPF Res value
        'Dim myreader As New IO.StreamReader("C:\Temp\WattageSelection.txt")
        Dim myreader As New IO.StreamReader(FileLoc_WattSelect)
        Dim line As String

        '****** Rated Wattage ******
        line = myreader.ReadLine()      'Read 1st line
        WattageSelection = line.Split(",")

        line = myreader.ReadLine()      'Read 2nd line
        LPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 3rd line
        LPF_Cap = line.Split(",")

        line = myreader.ReadLine()      'Read 4th line
        HPF_Res = line.Split(",")

        '****** Min Wattage ******
        line = myreader.ReadLine()      'Read 5th line
        MinWattageSelection = line.Split(",")

        line = myreader.ReadLine()      'Read 6th line
        MinLPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 7th line
        MinLPF_Cap = line.Split(",")

        line = myreader.ReadLine()      'Read 8th line
        MinHPF_Res = line.Split(",")

        '****** Overload Wattage ******
        line = myreader.ReadLine()      'Read 9th line
        OVLDWattageSelection = line.Split(",")

        line = myreader.ReadLine()      'Read 10th line
        OVLDLPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 11th line
        OVLDLPF_Cap = line.Split(",")


        myreader.Close()
    End Sub

    Public Sub ReadConfig()
        'Open the Configuration file
        Dim myreader As New IO.StreamReader(frmFileRead.tbxConfigFile.Text)
        '****** Rated Wattage ******
        myreader.ReadLine()                  'comment line - ignore
        FileLoc_Config = myreader.ReadLine()                  'Read line

        myreader.ReadLine()                  'comment line - ignore
        strTest_File_DirectoryLocation = myreader.ReadLine()

        myreader.ReadLine()                  'comment line - ignore
        FileLoc_WattSelect = myreader.ReadLine()              'Read line
        FileLoc_WattsToRelayLPFRes = myreader.ReadLine()      'Read line
        FileLoc_WattsToRelayLPFCap = myreader.ReadLine()      'Read line
        FileLoc_WattsToRelayHPFRes = myreader.ReadLine()      'Read line
        '****** Min Wattage ******
        FileLoc_MinWattSelect = myreader.ReadLine()              'Read line
        FileLoc_MinWattsToRelayLPFRes = myreader.ReadLine()      'Read line
        FileLoc_MinWattsToRelayLPFCap = myreader.ReadLine()      'Read line
        FileLoc_MinWattsToRelayHPFRes = myreader.ReadLine()      'Read line
        '****** Overload Wattage ******
        'NOTE: Overload uses same offset into array as Rated
        FileLoc_OVLDWattSelect = myreader.ReadLine()
        FileLoc_OVLDWattsToRelayLPFRes = myreader.ReadLine()      'Read line
        FileLoc_OVLDWattsToRelayLPFCap = myreader.ReadLine()      'Read line
        '****** ON_State_Relays ******
        FileLoc_ON_State_Relays = myreader.ReadLine()      'Read line
        FileLoc_OFF_State_Relays = myreader.ReadLine()      'Read line

    End Sub

    Public Sub Display_Relays(ByRef RelayArray() As String, ByRef line As String)
        line = ""        'clear text 
        For x = 1 To RelayArray.Length - 1
            If line = "" Then
                line = line & RelayArray(x)
            Else
                line = line & "," & RelayArray(x)
            End If
        Next
    End Sub

    Public Sub Close_Relays(ByRef RelayArray() As String)
        Dim DataValue As UInt16
        Dim RelayAdd As UInt16

        ''make public so each test can control
        ''Save Port A & B Image - Boards 1,2 
        'Dim Bd0_PortASave As UInt16 = 255 : Dim Bd0_PortBSave As UInt16 = 255
        'Dim Bd1_PortASave As UInt16 = 255 : Dim Bd1_PortBSave As UInt16 = 255
        ''Save PortC Image - Boards 1,2
        'Dim Bd0_PortCLSave As UInt16 = 15 : Dim Bd0_PortCHSave As UInt16 = 15
        'Dim Bd1_PortCLSave As UInt16 = 15 : Dim Bd1_PortCHSave As UInt16 = 15

        'determine which USB-DIO24 Board by evaluating Relay #
        'if Relay # < 25 then DIO24 board #1
        '   if Relay # < 9 then PortA, elseif Relay # < 17 then PortB else PortC
        'if Relay # > 24 & < 49 then DIO24 board #2
        '   if Relay # < 9 then PortA1, elseif Relay # < 17 then PortB1 else PortC1

        For x = 1 To RelayArray.Length - 1

            DataValue = RelayArray(x)       'read relay number
            If (DataValue < 25) Then
                'board #1
                If (DataValue < 9) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 1))      'convert Relay # to I/O address
                    Bd0_PortASave = Bd0_PortASave And RelayAdd  'update Port Image register
                    PortATest(Bd0_PortASave)                    'output updated port status
                ElseIf (DataValue < 17) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 9))      'convert Relay # to I/O address
                    Bd0_PortBSave = Bd0_PortBSave And RelayAdd  'update Port Image register
                    PortBTest(Bd0_PortBSave)                    'output updated port status
                ElseIf (DataValue < 21) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 17))     'convert Relay # to I/O address
                    Bd0_PortCLSave = Bd0_PortCLSave And RelayAdd 'update Port Image register
                    PortCLTest(Bd0_PortCLSave)                 'output updated port status
                Else
                    RelayAdd = 255 - (2 ^ (DataValue - 21))     'convert Relay # to I/O address
                    Bd0_PortCHSave = Bd0_PortCHSave And RelayAdd 'update Port Image register
                    PortCHTest(Bd0_PortCHSave)                 'output updated port status
                End If


            ElseIf (DataValue < 49) Then
                'board #2
                'account for 1st bank with 24 offset
                DataValue -= 24
                If (DataValue < 9) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 1))      'convert Relay # to I/O address
                    Bd1_PortASave = Bd1_PortASave And RelayAdd  'update Port Image register
                    PortATest1(Bd1_PortASave)                   'output updated port status
                ElseIf (DataValue < 17) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 9))      'convert Relay # to I/O address
                    Bd1_PortBSave = Bd1_PortBSave And RelayAdd  'update Port Image register
                    PortBTest1(Bd1_PortBSave)                   'output updated port status
                ElseIf (DataValue < 21) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 17))     'convert Relay # to I/O address
                    Bd1_PortCLSave = Bd1_PortCLSave And RelayAdd 'update Port Image register
                    PortCLTest1(Bd1_PortCLSave)                 'output updated port status
                Else
                    RelayAdd = 255 - (2 ^ (DataValue - 21))     'convert Relay # to I/O address
                    Bd1_PortCHSave = Bd1_PortCHSave And RelayAdd 'update Port Image register
                    PortCHTest1(Bd1_PortCHSave)                 'output updated port status
                End If


            ElseIf (DataValue < 73) Then
                'board #2
                'account for 1st bank with 24 offset
                DataValue -= 48
                If (DataValue < 9) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 1))      'convert Relay # to I/O address
                    Bd2_PortASave = Bd2_PortASave And RelayAdd  'update Port Image register
                    PortATest2(Bd2_PortASave)                   'output updated port status
                ElseIf (DataValue < 17) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 9))      'convert Relay # to I/O address
                    Bd2_PortBSave = Bd2_PortBSave And RelayAdd  'update Port Image register
                    PortBTest2(Bd2_PortBSave)                   'output updated port status
                ElseIf (DataValue < 21) Then
                    RelayAdd = 255 - (2 ^ (DataValue - 17))     'convert Relay # to I/O address
                    Bd2_PortCLSave = Bd2_PortCLSave And RelayAdd 'update Port Image register
                    PortCLTest2(Bd2_PortCLSave)                 'output updated port status
                Else
                    RelayAdd = 255 - (2 ^ (DataValue - 21))     'convert Relay # to I/O address
                    Bd2_PortCHSave = Bd2_PortCHSave And RelayAdd 'update Port Image register
                    PortCHTest2(Bd2_PortCHSave)                 'output updated port status
                End If
            End If

        Next
    End Sub


    Public Sub Open_Relays(ByRef RelayArray() As String)
        Dim DataValue As UInt16
        Dim RelayAdd As UInt16

        For x = 1 To RelayArray.Length - 1

            DataValue = RelayArray(x)       'read relay number
            If (DataValue < 25) Then
                'board #1
                If (DataValue < 9) Then
                    RelayAdd = (2 ^ (DataValue - 1))            'convert Relay # to I/O address
                    Bd0_PortASave = Bd0_PortASave Or RelayAdd  'update Port Image register
                    PortATest(Bd0_PortASave)                    'output updated port status
                ElseIf (DataValue < 17) Then
                    RelayAdd = (2 ^ (DataValue - 9))            'convert Relay # to I/O address
                    Bd0_PortBSave = Bd0_PortBSave And RelayAdd  'update Port Image register
                    PortBTest(Bd0_PortBSave)                    'output updated port status
                ElseIf (DataValue < 21) Then
                    RelayAdd = (2 ^ (DataValue - 17))           'convert Relay # to I/O address
                    Bd0_PortCLSave = Bd0_PortCLSave And RelayAdd 'update Port Image register
                    PortCLTest(Bd0_PortCLSave)                 'output updated port status
                Else
                    RelayAdd = (2 ^ (DataValue - 21))           'convert Relay # to I/O address
                    Bd0_PortCHSave = Bd0_PortCHSave And RelayAdd 'update Port Image register
                    PortCHTest(Bd0_PortCHSave)                 'output updated port status
                End If
            End If
        Next
    End Sub


    Public Sub GetRelaysFromFile(ByVal Filename As String, ByRef RelayList() As String, ByRef strLine As String, ByRef LineIndex As Integer)
        Dim myreader As New IO.StreamReader(Filename)
        Dim line As String : Dim Relaystr(2) As String

        myreader = My.Computer.FileSystem.OpenTextFileReader(Filename)

        For x = 0 To LineIndex                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        RelayList = Relaystr            'holds Relays to actuate 
        strLine = line
        myreader.Close()

    End Sub


    'Disconnect all Relays
    Public Sub Disconnect_Relays_Bd1_2_3()
        Dim DataValue As UInt16

        'Board 1 - Port Data Write
        DataValue = 255
        PortATest(DataValue)
        PortBTest(DataValue)
        PortCLTest(DataValue)
        PortCHTest(DataValue)

        'Board 2 - Port Data Write
        PortATest1(DataValue)
        PortBTest1(DataValue)
        PortCLTest1(DataValue)
        PortCHTest1(DataValue)

        'Board 3 - Port Data Write
        PortATest2(DataValue)
        PortBTest2(DataValue)
        PortCLTest2(DataValue)
        PortCHTest2(DataValue)

        'Reset Image Registers
        Bd0_PortASave = 255 : Bd0_PortBSave = 255
        Bd1_PortASave = 255 : Bd1_PortBSave = 255
        Bd2_PortASave = 255 : Bd2_PortBSave = 255
        'Save PortC Image - Boards 1,2
        Bd0_PortCLSave = 15 : Bd0_PortCHSave = 15
        Bd1_PortCLSave = 15 : Bd1_PortCHSave = 15
        Bd2_PortCLSave = 15 : Bd2_PortCHSave = 15

    End Sub

    Public Function gblGetTime(Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '

        'Seconds'
        Sec = Time Mod 60

        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function

End Module
