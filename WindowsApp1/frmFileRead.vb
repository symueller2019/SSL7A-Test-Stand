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
        Dim myreader As New IO.StreamReader("C:\Temp\ConfigFile.txt")

        'myreader = My.Computer.FileSystem.OpenTextFileReader("C:\Temp\WattsToRelays_LPF_Res.txt")
        ReadConfig()

        'Get list of all available Wattage test values - WattageSelectionFile
        Read_Text_Files()

        'verify values entered
        If tbxWattage.Text = "" Then
            MsgBox("Enter Value to Find")
            Return
        End If

        'Prevent user from actuating until task is done
        btnStart.Enabled = False

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


        btnStart.Enabled = True


    End Sub

    Private Sub frmFileRead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set default Configuration file location
        tbxConfigFile.Text = "C:\Temp\ConfigFile.txt"

    End Sub

End Class


