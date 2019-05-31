Imports System.ComponentModel

Public Class frmRepetitivePeakVoltage
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file


    Private Sub frmRepetitivePeakVoltage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display state of tester
        cbxRepPeakVoltage.Text = "HPF Min Load - 90 Deg Conduction Angle - Dimmer OFF"
        'display title of test
        lblTestDescription.Text = "Repetitive Peak Voltage"
        lblResultDsply.Text = ""
        'Show limits
        lblLimit.Text = "Limit"               '145% peak of mains
        lblLimitDsply.Text = "246.5V" 'clear Limit display

        'lblResult.Hide()                      'Hide Result label
        'lblResultDsply.Hide()                 'Hide Result display

        tbxRepetitivePeakVoltage.Enabled = False    'hide until user enter value

    End Sub

    Private Sub frmRepetitivePeakVoltage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Here when the "X" is press in the top right of the form
        GC.Collect()        'empty the garbage

        'Open all Res & Cap Relays
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub cbxRepPeakVoltage_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRepPeakVoltage.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'clear measurement entry 
        tbxMeasurementEntry.Text = ""
        tbxComment.Text = ""

        If cbxRepPeakVoltage.Checked = True Then

            'clear out previous value
            tbxRepetitivePeakVoltage.Text = ""

            'display title of test
            cbxRepPeakVoltage.Text = "HPF Min Load - 90 Deg Conduction Angle - Dimmer ON"
            'cbxRepPeakCurrent.Enabled = False
            'display title of test in Group Control box
            lblTestDescription.Text = "HPF Min Load - 90 Deg Conductive Angle Current"
            lblResultDsply.Text = ""

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays - disconnect loads & power
            Close_Relays(HPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'update result
            tbxRepetitivePeakVoltage.Text = tbxMeasurementEntry.Text

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

        If blnTestTitleDone = False Then
            FileWrite("Repetitive Peak Voltage Test")
            blnTestTitleDone = True
        End If

        'Entry Parameter check
        If IsNumeric(tbxMeasurementEntry.Text) = False Then
            MsgBox("must enter a numeric value")
            Return
        End If

        tbxRepetitivePeakVoltage.Enabled = True
        tbxRepetitivePeakVoltage.Text = tbxMeasurementEntry.Text     'display result status near select button - save test status

        'check user input - Pass/Fail status
        If Val(tbxMeasurementEntry.Text) < Val(lblLimitDsply.Text) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55) & ",")
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & "Vpk" & "," & lblResultDsply.Text.PadRight(6))
        FileWrite(tbxComment.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        GC.Collect()        'empty the garbage

        'Open all Res & Cap Relays
        Disconnect_Relays_Bd1_2_3()
        Close()

    End Sub
End Class