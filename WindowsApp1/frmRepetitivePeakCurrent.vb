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

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays
            Close_Relays(LPF_ResRelays)      'Resistor relays
            Close_Relays(LPF_CapRelays)      'Capacitor relays

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

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)

    End Sub

    Private Sub DisplayLoad()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Rated Watts"
        lblRes.Text = "Rated LPF Res"
        lblCap.Text = "Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline
    End Sub
End Class