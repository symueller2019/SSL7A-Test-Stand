Imports System.ComponentModel

Public Class MainForm1
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        lblDisplay.Text = "Hello World"
        'frmStability.Show()
        MessageBox.Show("Hello")
        If MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
            lblDisplay.Text = "YES"

        Else lblDisplay.Text = "NO"
        End If

        lblDate.Text = DateTime.Now.Date      'DateTime.Today.ToLongTimeString
        lblTime.Text = TimeOfDay
        lblSerialNum.Text = DateTime.Now.ToFileTime

        'test for github
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

    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)
    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)
    End Sub

    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click
        frmFileRead.Show()
    End Sub
End Class
