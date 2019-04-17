Imports System.ComponentModel

Public Class frmInRush
    Private Sub frmInRush_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adjust user controls
        lblLimit.Hide()                       'Hide Limit label
        lblLimitDsply.Hide()                  'Hide Limit display
        lblResult.Hide()                      'Hide Result label
        lblResultDsply.Hide()                 'Hide Result display

    End Sub

    Private Sub frmInRush_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub cbxMaxCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMaxCondAngle.CheckedChanged
        Dim DataValue As UInt16
        If cbxMaxCondAngle.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            cbxMaxCondAngle.Text = "Max Conduction Angle - Dimmer ON"
            cbx90DegCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF Rated Load - Max Conductive Angle Current"
            lblResultDsply.Text = ""

        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            cbxMaxCondAngle.Text = "Max Conduction Angle - Dimmer OFF"
            cbx90DegCondAngle.Enabled = True
        End If
    End Sub

    Private Sub cbx90DegCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbx90DegCondAngle.CheckedChanged
        Dim DataValue As UInt16
        If cbx90DegCondAngle.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            cbx90DegCondAngle.Text = "90 Deg. Conduction Angle - Dimmer ON"
            cbxMaxCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF Rated Load - 90 Deg. Conductive Angle Current"
            lblResultDsply.Text = ""
        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            cbx90DegCondAngle.Text = "90 Deg. Conduction Angle - Dimmer OFF"
            cbxMaxCondAngle.Enabled = True
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