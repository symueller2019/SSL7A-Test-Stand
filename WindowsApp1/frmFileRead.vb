Public Class frmFileRead

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myreader As New IO.StreamReader("C:\Temp\testcomma.txt")
        Dim line As String

        line = myreader.ReadLine()      'Read 1st line
        LPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 2nd line
        HPF_Res = line.Split(",")

        myreader.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x As Integer : Dim Index As Integer
        Dim Value As Integer
        Dim ValSng As Single
        Dim ValCmpSng As Single

        'verify values entered
        If TextBox2.Text = "" Then
            MsgBox("Enter Value to Find")
            Return
        End If

        'Prevent user from actuating until task is done
        Button6.Enabled = False

        Value = Val(TextBox2.Text)
        ValCmpSng = Val(TextBox4.Text)
        For x = 0 To LPF_Res.Length - 1
            If LPF_Res(x) = Value Then
                Index = x
                TextBox3.Text = Index
            End If
        Next x


        For x = 0 To HPF_Res.Length - 1
            'If HPF_Res(x) = Value Then
            ValSng = HPF_Res(x)
            If ValSng = ValCmpSng Then
                Index = x
                TextBox5.Text = Index
            End If
        Next x

        'Display HPF value at LPF Index
        Dim myreader As New IO.StreamReader("C:\Temp\testcomma.txt")
        Dim line As String
        Dim HPF_Value_At_Index() As String        'must give element limit
        Value = Val(TextBox3.Text)      'LPF index value
        line = myreader.ReadLine()      'Read 1st line - LPF
        line = myreader.ReadLine()      'Read 2nd line - LPF
        HPF_Value_At_Index = line.Split(",")
        'LPF_Res = line.Split(",")
        TextBox6.Text = HPF_Value_At_Index(Value)


        'Dim myreader As New IO.StreamReader("C:\Temp\test.txt")
        myreader = My.Computer.FileSystem.OpenTextFileReader("C:\Temp\test.txt")
        'Display Relays to Close using LPF Index
        ' Index to line and display values
        Dim Relaystr() As String
        For x = 0 To Value      'LPF_Res.Length - 1
            line = myreader.ReadLine()      'Read 1st line
        Next

        Relaystr = line.Split(",")          'Relaystr is array of individual elements
        '1st:ID
        'display Relays to Close
        TextBox7.Text = line
        'extract 1st Relay

        'Timer1.Enabled = True
        'Timer1.Start()              '5 seconds
        'While Delay = False
        'End While
        While Timer1.Enabled = True
        End While

        For x = 1 To Relaystr.Length - 1
            TextBox8.Text = Relaystr(x)         '& " & " & Relaystr(2)
            Me.Refresh()

            TextBox8.Refresh()

            timersetup()

            While Timer1.Enabled = True
                System.Windows.Forms.Application.DoEvents() '***** MUST HAVE to RESPOND to TIMER *****
            End While

            'SW timer
            'For z = 1 To 500000
            '    TextBox8.Text = Relaystr(x)
            'Next z

        Next x

        Button6.Enabled = True

    End Sub
    Private Sub timersetup()
        Timer1.Enabled = True
        Timer1.Start()              '5 seconds
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim x As Integer : Dim Index As Integer
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

        'Read Indexed values from the LPF Res, LPF Cap and HPF Res arrays
        tbxLPF_Res.Text = LPF_Res(Index)
        tbxLPF_Cap.Text = LPF_Cap(Index)
        tbxHPF_Res.Text = HPF_Res(Index)

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

        btnStart.Enabled = True


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set default Configuration file location
        tbxConfigFile.Text = "C:\Temp\ConfigFile.txt"
    End Sub
End Class


