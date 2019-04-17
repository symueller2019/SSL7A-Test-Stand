Imports System.ComponentModel

Public Class frmRepetitivePeakVoltage
    Private Sub pbxRepetitivePeakVoltageText_Click(sender As Object, e As EventArgs) Handles pbxRepetitivePeakVoltageText.Click

    End Sub

    Private Sub pbxRepetitivePeakVoltageChart_Click(sender As Object, e As EventArgs) Handles pbxRepetitivePeakVoltageChart.Click

    End Sub

    Private Sub frmRepetitivePeakVoltage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display state of tester
        cbxRepPeakVoltage.Text = "HPF Min Load - 90 Deg Conduction Angle - Dimmer OFF"
        'display title of test
        lblTestDescription.Text = "Repetitive Peak Voltage"
        lblResultDsply.Text = ""
        'Show limits
        lblLimit.Text = "Limit"               '145% peak of mains
        lblLimitDsply.Text = "246.5V" 'clear Limit display

        'Adjust user Group controls
        'lblLimit.Hide()                       'Hide Limit label
        'lblLimitDsply.Hide()                  'Hide Limit display
        lblResult.Hide()                      'Hide Result label
        lblResultDsply.Hide()                 'Hide Result display
    End Sub

    Private Sub frmRepetitivePeakVoltage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Here when the "X" is press in the top right of the form
        GC.Collect()        'empty the garbage
    End Sub

    Private Sub cbxRepPeakVoltage_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRepPeakVoltage.CheckedChanged
        Dim DataValue As UInt16
        If cbxRepPeakVoltage.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test
            cbxRepPeakVoltage.Text = "HPF Min Load - 90 Deg Conduction Angle - Dimmer ON"
            'cbxRepPeakCurrent.Enabled = False
            'display title of test in Group Control box
            lblTestDescription.Text = "HPF Min Load - 90 Deg Conductive Angle Current"
            lblResultDsply.Text = ""

        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            'display title of test
            cbxRepPeakVoltage.Text = "Dimmer OFF"
            'cbxRepPeakCurrent.Enabled = True
        End If
    End Sub

End Class