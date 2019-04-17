Imports System.ComponentModel

Public Class frmRepetitivePeakCurrent
    Private Sub frmRepetitivePeakCurrent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display state of tester
        cbxRepPeakCurrent.Text = "LPF Rated Load - 90 Deg Conduction Angle - Dimmer OFF"
        'display title of test
        lblTestDescription.Text = "Repetitive Peak Current"
        lblResultDsply.Text = ""
        'Adjust user Group controls
        lblLimit.Hide()                       'Hide Limit label
        lblLimitDsply.Hide()                  'Hide Limit display
        lblResult.Hide()                      'Hide Result label
        lblResultDsply.Hide()                 'Hide Result display

    End Sub

    Private Sub frmRepetitivePeakCurrent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub cbxRepPeakCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRepPeakCurrent.CheckedChanged
        Dim DataValue As UInt16
        If cbxRepPeakCurrent.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test
            cbxRepPeakCurrent.Text = "LPF Rated Load - 90 Deg Conduction Angle - Dimmer ON"
            'cbxRepPeakCurrent.Enabled = False
            'display title of test in Group Control box
            lblTestDescription.Text = "LPF Rated Load - 90 Deg Conductive Angle Current"
            lblResultDsply.Text = ""

        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            'display title of test
            cbxRepPeakCurrent.Text = "90 Deg Conduction Angle - Dimmer OFF"
            'cbxRepPeakCurrent.Enabled = True
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim LPF_Value As String

        ''Determine Pass/Fail status
        'If Val(lblLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
        '    lblResultDsply.Text = "PASS"
        'Else
        '    lblResultDsply.Text = "FAIL"
        'End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)

        'LPF_Value = tbxMeasurementEntry.Text & tbxComment.Text
        'FileWrite(LPF_Value)

        'LPF_Value = tbxComment.Text
    End Sub
End Class