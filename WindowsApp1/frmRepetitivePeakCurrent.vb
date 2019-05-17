Imports System.ComponentModel

Public Class frmRepetitivePeakCurrent
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file
    Dim intDuration As UInt16


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
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub cbxRepPeakCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRepPeakCurrent.CheckedChanged
        Dim DataValue As UInt16

        'start timer
        Timer1.Enabled = True

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'clear measurement entry 
        tbxMeasurementEntry.Text = ""

        If cbxRepPeakCurrent.Checked = True Then

            'display title of test
            cbxRepPeakCurrent.Text = "LPF Rated Load - 90 Deg Conduction Angle - Dimmer ON"
            'cbxRepPeakCurrent.Enabled = False
            'display title of test in Group Control box
            lblTestDescription.Text = "LPF Rated Load - 90 Deg Conductive Angle Current"
            lblResultDsply.Text = ""

            DisplayLoad()           'display Res & Cap load with Relay info

            'close Relays - connect loads & power
            Close_Relays(LPF_ResRelays)      'Resistor relays
            Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            Timer1.Enabled = False

            'display title of test
            cbxRepPeakCurrent.Text = "90 Deg Conduction Angle - Dimmer OFF"
            'cbxRepPeakCurrent.Enabled = True
        End If
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

        tbxRepetitivePeakCurrent.Text = tbxMeasurementEntry.Text     'display result status near select button - save test status

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intDuration += 1
        tbxRepetitivePeakCurrentTime.Text = intDuration + 1

        tbxRepetitivePeakCurrentTime.Text = gblGetTime(intDuration)
    End Sub

    'Public Function gblGetTime(Time As Integer) As String
    '    Dim Hrs As Integer  'number of hours   '
    '    Dim Min As Integer  'number of Minutes '
    '    Dim Sec As Integer  'number of Sec     '

    '    'Seconds'
    '    Sec = Time Mod 60

    '    'Minutes'
    '    Min = ((Time - Sec) / 60) Mod 60

    '    'Hours'
    '    Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

    '    Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    'End Function
End Class