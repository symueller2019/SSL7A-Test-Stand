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

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays
            Close_Relays(HPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            'display title of test
            cbxRepPeakVoltage.Text = "Dimmer OFF"
            'cbxRepPeakCurrent.Enabled = True
        End If
    End Sub

    Private Sub DisplayLoad()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)
    End Sub
End Class