Imports System.ComponentModel

Public Class MainForm1
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click

        'DialogResult = MessageBox.Show("New Test?", "Run Test", MessageBoxButtons.YesNoCancel)
        'If DialogResult = DialogResult.Yes Then
        '    MessageBox.Show("Yes pressed")
        'ElseIf DialogResult = DialogResult.No Then
        '    MessageBox.Show("No pressed")
        'ElseIf DialogResult = DialogResult.Cancel Then
        '    MessageBox.Show("Cancel pressed", "MessageBox Title", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        frmFileRead.Show()
        While Index = 0
            'My.Application.DoEvents()
            System.Windows.Forms.Application.DoEvents()
        End While

        lblDate.Text = DateTime.Now.Date      'DateTime.Today.ToLongTimeString
        lblTime.Text = TimeOfDay
        lblSerialNum.Text = DateTime.Now.ToFileTime

        tbxConfigFile.Text = FileLoc_Config

        'display test info - Rated Load
        tbxWattage.Text = WattageSelection(Index)
        tbxLPF_Res.Text = LPF_Res(Index)
        tbxLPF_Cap.Text = LPF_Cap(Index)
        tbxHPF_Res.Text = HPF_Res(Index)

        'display test info - Min Load
        tbxMinWattage.Text = MinWattageSelection(MinIndex)
        tbxMinLPF_Res.Text = MinLPF_Res(MinIndex)
        tbxMinLPF_Cap.Text = MinLPF_Cap(MinIndex)
        tbxMinHPF_Res.Text = MinHPF_Res(MinIndex)
        'display test info - O/L Load
        tbxOVLDWattage.Text = Val(1.2 * Val(WattageSelection(Index)))
        tbxOVLDLPF_Res.Text = OVLDLPF_Res(Index)
        tbxOVLDLPF_Cap.Text = OVLDLPF_Cap(Index)

        'Init textboxs
        '****** Rated Load Relays ******
        tbxLPF_ResRelays.Text = ""
        tbxLPF_CapRelays.Text = ""
        tbxHPF_ResRelays.Text = ""
        '***** Min Load Relays *****
        tbxMinLPF_ResRelays.Text = ""
        tbxMinLPF_CapRelays.Text = ""
        tbxMinHPF_ResRelays.Text = ""
        '****** O/L Load Relays ******
        tbxOVLDLPF_ResRelays.Text = ""
        tbxOVLDLPF_CapRelays.Text = ""

        'display Relay connections
        '******************* Rated Load ****************
        For x = 1 To LPF_ResRelays.Length - 1    'start with "1" to skip Identifier
            If tbxLPF_ResRelays.Text = "" Then
                tbxLPF_ResRelays.Text = tbxLPF_ResRelays.Text & LPF_ResRelays(x)
            Else
                tbxLPF_ResRelays.Text = tbxLPF_ResRelays.Text & "," & LPF_ResRelays(x)
            End If
        Next

        For x = 1 To LPF_CapRelays.Length - 1    'start with "1" to skip Identifier
            If tbxLPF_CapRelays.Text = "" Then
                tbxLPF_CapRelays.Text = tbxLPF_CapRelays.Text & LPF_CapRelays(x)
            Else
                tbxLPF_CapRelays.Text = tbxLPF_CapRelays.Text & "," & LPF_CapRelays(x)
            End If
        Next

        For x = 1 To HPF_ResRelays.Length - 1    'start with "1" to skip Identifier
            If tbxHPF_ResRelays.Text = "" Then
                tbxHPF_ResRelays.Text = tbxHPF_ResRelays.Text & HPF_ResRelays(x)
            Else
                tbxHPF_ResRelays.Text = tbxHPF_ResRelays.Text & "," & HPF_ResRelays(x)
            End If
        Next

        '******************* Minimum Load ****************
        For x = 1 To MinLPF_ResRelays.Length - 1    'start with "1" to skip Identifier
            If tbxMinLPF_ResRelays.Text = "" Then
                tbxMinLPF_ResRelays.Text = tbxMinLPF_ResRelays.Text & MinLPF_ResRelays(x)
            Else
                tbxMinLPF_ResRelays.Text = tbxMinLPF_ResRelays.Text & "," & MinLPF_ResRelays(x)
            End If
        Next

        For x = 1 To MinLPF_CapRelays.Length - 1    'start with "1" to skip Identifier
            If tbxMinLPF_CapRelays.Text = "" Then
                tbxMinLPF_CapRelays.Text = tbxMinLPF_CapRelays.Text & MinLPF_CapRelays(x)
            Else
                tbxMinLPF_CapRelays.Text = tbxMinLPF_CapRelays.Text & "," & MinLPF_CapRelays(x)
            End If
        Next

        For x = 1 To MinHPF_ResRelays.Length - 1    'start with "1" to skip Identifier
            If tbxMinHPF_ResRelays.Text = "" Then
                tbxMinHPF_ResRelays.Text = tbxMinHPF_ResRelays.Text & MinHPF_ResRelays(x)
            Else
                tbxMinHPF_ResRelays.Text = tbxMinHPF_ResRelays.Text & "," & MinHPF_ResRelays(x)
            End If
        Next

        '******************* O/L Load **********************
        For x = 1 To OVLDLPF_ResRelays.Length - 1
            If tbxOVLDLPF_ResRelays.Text = "" Then
                tbxOVLDLPF_ResRelays.Text = tbxOVLDLPF_ResRelays.Text & OVLDLPF_ResRelays(x)
            Else
                tbxOVLDLPF_ResRelays.Text = tbxOVLDLPF_ResRelays.Text & "," & OVLDLPF_ResRelays(x)
            End If
        Next

        For x = 1 To OVLDLPF_CapRelays.Length - 1
            If tbxOVLDLPF_CapRelays.Text = "" Then
                tbxOVLDLPF_CapRelays.Text = tbxOVLDLPF_CapRelays.Text & OVLDLPF_CapRelays(x)
            Else
                tbxOVLDLPF_CapRelays.Text = tbxOVLDLPF_CapRelays.Text & "," & OVLDLPF_CapRelays(x)
            End If
        Next


    End Sub

    Private Sub btnFullTestSuite_Click(sender As Object, e As EventArgs) Handles btnFullTestSuite.Click
        'Use ShowDialog() to make forms Modal - only single form is active & control release when form is closed
        frmStability.ShowDialog()
        frmInRush.ShowDialog()
        frmRepetitivePeakCurrent.ShowDialog()
        frmOverload.ShowDialog()
        frmRepetitivePeakVoltage.ShowDialog()
        frmOffStateOperation.ShowDialog()
        frmOnStateSupplyCurrent.ShowDialog()
        frmMax_MinOnStateConAngle.ShowDialog()

    End Sub

    Private Sub btnStabilityTests_Click(sender As Object, e As EventArgs) Handles btnStabilityTests.Click
        frmStability.Show()
    End Sub

    Private Sub btnInRushCurrent_Click(sender As Object, e As EventArgs) Handles btnInRushCurrent.Click
        frmInRush.Show()
    End Sub

    Private Sub btnRepetitivePeakCurrent_Click(sender As Object, e As EventArgs) Handles btnRepetitivePeakCurrent.Click
        frmRepetitivePeakCurrent.Show()
    End Sub

    Private Sub btnOverload_Click(sender As Object, e As EventArgs) Handles btnOverload.Click
        frmOverload.Show()
    End Sub

    Private Sub btnRepetitivePeakVoltage_Click(sender As Object, e As EventArgs) Handles btnRepetitivePeakVoltage.Click
        frmRepetitivePeakVoltage.Show()
    End Sub

    Private Sub btnOffStateOperation_Click(sender As Object, e As EventArgs) Handles btnOffStateOperation.Click
        frmOffStateOperation.Show()
    End Sub

    Private Sub btnOnStateDmrSupplyCurrent_Click(sender As Object, e As EventArgs) Handles btnOnStateDmrSupplyCurrent.Click
        frmOnStateSupplyCurrent.Show()
    End Sub

    Private Sub btnMinOnConAngle_Click(sender As Object, e As EventArgs) Handles btnMinOnConAngle.Click
        frmMax_MinOnStateConAngle.Show()
    End Sub

    Private Sub MainForm1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub MainForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DaqSetup()          'Setup & Initialize the I/O board
        'Dim WriteData = "test123"
        'FileWrite(WriteData)
    End Sub

    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click
        frmFileRead.Show()
    End Sub

End Class
