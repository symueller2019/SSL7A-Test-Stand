Imports System.ComponentModel


Public Class frmInRush
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file

    Private Sub frmInRush_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adjust user controls
        lblLimit.Hide()                       'Hide Limit label
        lblLimitDsply.Hide()                  'Hide Limit display
        lblResult.Hide()                      'Hide Result label
        lblResultDsply.Hide()                 'Hide Result display

    End Sub

    Private Sub frmInRush_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form

        Disconnect_Relays_Bd1_2()
    End Sub

    Private Sub cbxMaxCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMaxCondAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If cbxMaxCondAngle.Checked = True Then
            cbxMaxCondAngle.Text = "Max Conduction Angle - Dimmer ON"
            cbx90DegCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF Rated Load - Max Conductive Angle Current"
            lblResultDsply.Text = ""

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays - connect loads & power
            Close_Relays(LPF_ResRelays)      'Resistor relays
            Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'disconnect loads & power
            cbxMaxCondAngle.Text = "Max Conduction Angle - Dimmer OFF"
            cbx90DegCondAngle.Enabled = True
        End If
    End Sub

    Private Sub cbx90DegCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbx90DegCondAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If cbx90DegCondAngle.Checked = True Then
            cbx90DegCondAngle.Text = "90 Deg. Conduction Angle - Dimmer ON"
            cbxMaxCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF Rated Load - 90 Deg. Conductive Angle Current"
            lblResultDsply.Text = ""

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays - connect loads & power
            Close_Relays(LPF_ResRelays)      'Resistor relays
            Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'disconnect loads & power
            cbx90DegCondAngle.Text = "90 Deg. Conduction Angle - Dimmer OFF"
            cbxMaxCondAngle.Enabled = True
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If blnTestTitleDone = False Then
            FileWrite("InRush Current Test")
            blnTestTitleDone = True         'only write test name once
        End If
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