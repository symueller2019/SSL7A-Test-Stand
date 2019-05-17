Imports System.ComponentModel       'needed for Form Closing event

'Notes on keys "Return" & "ESC"
'If you are In a windows application form, you can use the properties AcceptButton
'And CancelButton On the form properties, setting the name Of your buttons.
'AcceptButton fires When you press Enter key
'CencelButton fires When you press Esc key

Public Class frmFileRead

    Private Sub timersetup()
        Timer1.Enabled = True
        Timer1.Start()              '5 seconds
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    'Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
    Public Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim x As Integer ': Dim Index As Integer
        Dim Value As Integer

        'Give warning that if no Test filename entered, one is generated
        If tbxTestResultFilename.Text = "" Then
            MsgBox("if no filename entered - one is generated")
        End If


        ReadConfig()

        'Get location of Test Configuration text file 
        Dim myreader As New IO.StreamReader(FileLoc_Config)

        'Get list of all available Wattage test values - WattageSelectionFile
        Read_Text_Files()

        'verify values entered
        'If tbxWattage.Text = "" Then
        If ListBox1.SelectedItem = "" Then
            MsgBox("Enter Rated Wattage Value - Click Inside Selection Box - turns BLUE")
            Return
        End If

        'If tbxMinWattage.Text = "" Then
        If ListBox2.SelectedItem = "" Then
            MsgBox("Enter Minimum Wattage Value - Click Inside Selection Box - turns BLUE")
            Return
        End If


        'Overload Wattage is 120% of Rated
        tbxOVLDWattage.Text = Val(1.2 * Val(tbxWattage.Text))

        'Prevent user from actuating until task is done
        btnStart.Enabled = False


        '******************** Rated Wattage *******************

        'Find Index to User Wattage entry in Wattage Selection File
        Value = Val(tbxWattage.Text)
        For x = 0 To WattageSelection.Length - 1
            If Val(WattageSelection(x)) = Value Then
                Index = x
                tbxIndexToTables.Text = Index
            End If
        Next x
        'Me.tbxIndexToTables.Update()
        'System.Windows.Forms.Application.DoEvents()     'force screen update to see change

        'Read & display Indexed values from the LPF Res, LPF Cap and HPF Res arrays
        tbxLPF_Res.Text = LPF_Res(Index)
        tbxLPF_Cap.Text = LPF_Cap(Index)
        tbxHPF_Res.Text = HPF_Res(Index)


        '******************** Minimum Wattage *******************

        'Find Index to User Wattage entry in Wattage Selection File
        Value = Val(tbxMinWattage.Text)
        For x = 0 To MinWattageSelection.Length - 1
            If Val(MinWattageSelection(x)) = Value Then
                MinIndex = x
                tbxIndexToMinTables.Text = MinIndex
            End If
        Next x
        'Me.tbxIndexToTables.Update()
        'System.Windows.Forms.Application.DoEvents()     'force screen update to see change

        'Read & display Indexed values from the LPF Res, LPF Cap and HPF Res arrays
        tbxMinLPF_Res.Text = MinLPF_Res(MinIndex)
        tbxMinLPF_Cap.Text = MinLPF_Cap(MinIndex)
        tbxMinHPF_Res.Text = MinHPF_Res(MinIndex)


        '******************** Overload Wattage *******************

        'Find Index to User Wattage entry in Wattage Selection File
        'Value = Val(tbxOVLDWattage.Text)
        'Value = Val(tbxWattage.Text)        'use same index as Rated - 1 to 1 correspondance
        'For x = 0 To OVLDWattageSelection.Length - 1
        '    If Val(OVLDWattageSelection(x)) = Value Then
        '        OVLDIndex = x
        '        tbxIndexToOVLDTables.Text = OVLDIndex
        '    End If
        'Next x
        'Me.tbxIndexToTables.Update()
        'System.Windows.Forms.Application.DoEvents()     'force screen update to see change

        'Read & display Indexed values from the LPF Res, LPF Cap and HPF Res arrays
        tbxIndexToOVLDTables.Text = Index            'use same index as Rated - 1 to 1 correspondance
        tbxOVLDLPF_Res.Text = OVLDLPF_Res(Index)
        tbxOVLDLPF_Cap.Text = OVLDLPF_Cap(Index)
        'tbxMinHPF_Res.Text = MinHPF_Res(MinIndex)

        '******************** Rate Wattage ***********************

        'Use index value to extract Relay Addresses
        ' scan must be done by line as there are multiple relay closures for Res & Cap
        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_WattsToRelayLPFRes)
        'Display Relays to Close using Wattage Selection Index
        ' Index to line and display values
        Dim Relaystr() As String
        Dim line As String
        For x = 0 To Index                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next

        Relaystr = line.Split(",")          'Relaystr is array holding all elements of text line
        'display Relays to Close
        For x = 1 To Relaystr.Length - 1    'start with "1" to skip Identifier
            If tbxLPF_ResRelays.Text = "" Then
                tbxLPF_ResRelays.Text = tbxLPF_ResRelays.Text & Relaystr(x)
            Else
                tbxLPF_ResRelays.Text = tbxLPF_ResRelays.Text & "," & Relaystr(x)
            End If
        Next
        LPF_ResRelays = Relaystr            'holds Relays to actuate 

        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_WattsToRelayLPFCap)
        For x = 0 To Index                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxLPF_CapRelays.Text = "" Then
                tbxLPF_CapRelays.Text = tbxLPF_CapRelays.Text & Relaystr(x)
            Else
                tbxLPF_CapRelays.Text = tbxLPF_CapRelays.Text & "," & Relaystr(x)
            End If
        Next
        LPF_CapRelays = Relaystr            'holds Relays to actuate 

        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_WattsToRelayHPFRes)
        For x = 0 To Index                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxHPF_ResRelays.Text = "" Then
                tbxHPF_ResRelays.Text = tbxHPF_ResRelays.Text & Relaystr(x)
            Else
                tbxHPF_ResRelays.Text = tbxHPF_ResRelays.Text & "," & Relaystr(x)
            End If
        Next
        HPF_ResRelays = Relaystr            'holds Relays to actuate 

        '************************ Minimum Wattage **********************

        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_MinWattsToRelayLPFRes)
        For x = 0 To MinIndex                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxMinLPF_ResRelays.Text = "" Then
                tbxMinLPF_ResRelays.Text = tbxMinLPF_ResRelays.Text & Relaystr(x)
            Else
                tbxMinLPF_ResRelays.Text = tbxMinLPF_ResRelays.Text & "," & Relaystr(x)
            End If
        Next
        MinLPF_ResRelays = Relaystr            'holds Relays to actuate 


        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_MinWattsToRelayLPFCap)
        For x = 0 To MinIndex                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxMinLPF_CapRelays.Text = "" Then
                tbxMinLPF_CapRelays.Text = tbxMinLPF_CapRelays.Text & Relaystr(x)
            Else
                tbxMinLPF_CapRelays.Text = tbxMinLPF_CapRelays.Text & "," & Relaystr(x)
            End If
        Next
        MinLPF_CapRelays = Relaystr            'holds Relays to actuate 


        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_MinWattsToRelayHPFRes)
        For x = 0 To MinIndex                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxMinHPF_ResRelays.Text = "" Then
                tbxMinHPF_ResRelays.Text = tbxMinHPF_ResRelays.Text & Relaystr(x)
            Else
                tbxMinHPF_ResRelays.Text = tbxMinHPF_ResRelays.Text & "," & Relaystr(x)
            End If
        Next
        MinHPF_ResRelays = Relaystr            'holds Relays to actuate 


        '************************ Overload Wattage **********************
        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_OVLDWattsToRelayLPFRes)
        For x = 0 To Index                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxOVLDLPF_ResRelays.Text = "" Then
                tbxOVLDLPF_ResRelays.Text = tbxOVLDLPF_ResRelays.Text & Relaystr(x)
            Else
                tbxOVLDLPF_ResRelays.Text = tbxOVLDLPF_ResRelays.Text & "," & Relaystr(x)
            End If
        Next
        OVLDLPF_ResRelays = Relaystr            'holds Relays to actuate 


        myreader = My.Computer.FileSystem.OpenTextFileReader(FileLoc_OVLDWattsToRelayLPFCap)
        For x = 0 To Index                  'Index to line
            line = myreader.ReadLine()      'Read line
        Next
        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        For x = 1 To Relaystr.Length - 1
            If tbxOVLDLPF_CapRelays.Text = "" Then
                tbxOVLDLPF_CapRelays.Text = tbxOVLDLPF_CapRelays.Text & Relaystr(x)
            Else
                tbxOVLDLPF_CapRelays.Text = tbxOVLDLPF_CapRelays.Text & "," & Relaystr(x)
            End If
        Next
        OVLDLPF_CapRelays = Relaystr            'holds Relays to actuate 


        btnStart.Enabled = True

        'write setup to test file
        Write_SetupToFile()

        MainForm1.btnFullTestSuite.Enabled = True
        MainForm1.btnStabilityTests.Enabled = True
        MainForm1.btnInRushCurrent.Enabled = True
        MainForm1.btnRepetitivePeakCurrent.Enabled = True
        MainForm1.btnOverload.Enabled = True
        MainForm1.btnRepetitivePeakVoltage.Enabled = True
        MainForm1.btnOffStateOperation.Enabled = True
        MainForm1.btnOnStateDmrSupplyCurrent.Enabled = True
        MainForm1.btnMinOnConAngle.Enabled = True

    End Sub

    Private Sub frmFileRead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set default Configuration file location
        tbxConfigFile.Text = "C:\temp\ConfigFile.txt"
        AcceptButton = btnStart

        '****************** test ****************
        Dim x As Integer
        ReadConfig()            'get config files
        Read_Text_Files()       'read in files

        'selected Rated Load in Watts
        For x = 1 To WattageSelection.Length - 1
            ListBox1.Items.Add(WattageSelection(x))
        Next x

        'selected Minimum Load in Watts
        For x = 1 To MinWattageSelection.Length - 1
            ListBox2.Items.Add(MinWattageSelection(x))
        Next x

        tbxWattage.Enabled = False
        tbxMinWattage.Enabled = False
        '****************************************

        lblDefaultDir.Text = "Default Dir:" & " " & strTest_File_DirectoryLocation

    End Sub

    Private Sub frmFileRead_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        blnFormHold = False     'allow parameters on MainForm to be updated with parameters from frm FileRead
        GC.Collect()            'collect garbage - release system memory

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'load Rated Wattage selection
        tbxWattage.Enabled = True
        tbxWattage.Text = ListBox1.SelectedItem

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        'load Minimum Wattage selection
        tbxMinWattage.Enabled = True
        tbxMinWattage.Text = ListBox2.SelectedItem

    End Sub

    Private Sub Write_SetupToFile()

        'if user has NOT entered a filename - generate
        If tbxTestResultFilename.Text = "" Then
            TestResultFilename = DateTime.Now.ToString("ddMMyyyy") & "_" & TimeOfDay.ToString("hhmmss") 'Test filename
            TestResultFilename = strTest_File_DirectoryLocation & TestResultFilename & ".txt"
            tbxTestResultFilename.Text = TestResultFilename
            FileWrite("Test Name:" & "  " & TestResultFilename)       'write filename into file
        Else
            TestResultFilename = strTest_File_DirectoryLocation & tbxTestResultFilename.Text & ".txt"
        End If

        FileWrite("Test Setup Parameters")
        FileWrite("** Test Loads **" & "  Rated Wattage: " & tbxWattage.Text & "   Min Wattage: " & tbxMinWattage.Text)  'write Rated & Min Test Wattage
        FileWrite("   LPF_Res: " & LPF_Res(Index) & "     LPF_Cap: " & LPF_Cap(Index) & "     HPF_Res: " & HPF_Res(Index))
        FileWrite("MinLPF_Res: " & MinLPF_Res(MinIndex) & "  MinLPF_Cap: " & MinLPF_Cap(MinIndex) & "  MinHPF_Res: " & MinHPF_Res(MinIndex))
        FileWrite("O/DLPF_Res: " & OVLDLPF_Res(Index) & "  O/DLPF_Cap: " & OVLDLPF_Cap(Index))
        FileWriteCRLF()     'linespace to separate the test results from Setup parameters

    End Sub

End Class


