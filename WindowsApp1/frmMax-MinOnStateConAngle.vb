Imports System.ComponentModel

Public Class frmMax_MinOnStateConAngle
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file
    Dim StatusArray(3) As TextBox           'array of status textbox for display results
    Dim s_index As Integer                  'index for array of textboxes

    Private Sub frmMax_MinOnStateConAngle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusArray(0) = tbxStatus0
        StatusArray(1) = tbxStatus1
        StatusArray(2) = tbxStatus2
        StatusArray(3) = tbxStatus3

        'select button test status invisible until test done
        For s_index = 0 To 3
            StatusArray(s_index).Visible = False
        Next

    End Sub

    Private Sub frmMax_MinOnStateConAngle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'pbxMaxMinOnStateConductionAngle.Image.Dispose()
        GC.Collect()
        'turn off dimmer power

        'Open all Res & Cap Relays
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub cbxMinLoad_MinAngle_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbxMinLoad_MinAngle.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 0                           'associate the label to this test
        StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbxMinLoad_MinAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Disable other controls
            cbxRatedLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            ''display title of test
            'cbxMaxCondAngle.Text = "LPF 120% Rated Load-Max Conduction Angle - Dimmer ON"
            'cbx90DegCondAngle.Enabled = False
            'display title of test in Group box
            lblTestDescription.Text = "HPF Min Load - Min Conduction Angle"

            'display limits
            lblResultDsply.Text = ""
            tbxLimitDsply.Text = "1.62 msec" & vbCrLf & "to" & vbCrLf & "2.083 msec"

            DisplayLoad_Min_Min()

            'close Relays - connect loads & power
            Close_Relays(MinHPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            StatusArray(s_index).Text = tbxMeasurementEntry.Text

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Restore other controls
            cbxRatedLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxRatedLoad_MinAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRatedLoad_MinAngle.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 2                           'associate the label to this test
        StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbxRatedLoad_MinAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Rated Load - Min Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "1.62 msec" & vbCrLf & "to" & vbCrLf & "2.083 msec"

            DisplayLoad_Rated_Min()

            'close Relays - connect loads & power
            Close_Relays(LPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            'tbxStatus1.Text = tbxMeasurementEntry.Text
            StatusArray(s_index).Text = tbxMeasurementEntry.Text

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxMinLoad_MaxAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMinLoad_MaxAngle.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 1                           'associate the label to this test
        StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbxMinLoad_MaxAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxRatedLoad_MinAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Min Load - Max Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = ">130 Deg" & vbCrLf & "(6.02 msec)"

            DisplayLoad_Min_Max()

            'close Relays - connect loads & power
            Close_Relays(MinHPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            'tbxStatus2.Text = tbxMeasurementEntry.Text
            StatusArray(s_index).Text = tbxMeasurementEntry.Text

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxRatedLoad_MinAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxRatedLoad_MaxAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRatedLoad_MaxAngle.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        If (cbxRatedLoad_MaxAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'do not show until test result done
            s_index = 3                           'associate the label to this test
            StatusArray(s_index).Visible = True  'show when test becomes active

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxRatedLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Rated Load - Max Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = ">130 Deg" & vbCrLf & "(6.02 msec)"

            DisplayLoad_Rated_Max()

            'close Relays - disconnect loads & power
            Close_Relays(HPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            tbxStatus3.Text = tbxMeasurementEntry.Text

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxRatedLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub DisplayLoad_Min_Min()
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

    Private Sub DisplayLoad_Rated_Min()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Rated Watts"
        lblRes.Text = "Rated HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = HPF_Res(Index)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub DisplayLoad_Min_Max()
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

    Private Sub DisplayLoad_Rated_Max()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Rated Watts"
        lblRes.Text = "Rated HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = HPF_Res(Index)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If blnTestTitleDone = False Then
            FileWrite("Max & Min On-State Conduction Angle")
            blnTestTitleDone = True
        End If

        'Entry Parameter check
        If IsNumeric(tbxMeasurementEntry.Text) = False Then
            MsgBox("must enter a numeric value")
            Return
        End If

        StatusArray(s_index).Text = tbxMeasurementEntry.Text     'display result status near select button - save test status

        Select Case s_index
            Case 0, 2
                If Val(StatusArray(s_index).Text) >= 1.62 And Val(StatusArray(s_index).Text) <= 2.083 Then
                    lblResultDsply.Text = "PASS"
                    'lblResultDsply.ForeColor = Color.White
                    'StatusArray(s_index).BackColor = Color.White
                Else
                    lblResultDsply.Text = "FAIL"
                    'lblResultDsply.ForeColor = Color.Red
                    'StatusArray(s_index).BackColor = Color.Red
                End If

            Case 1, 3
                If Val(StatusArray(s_index).Text) >= 6.02 And Val(StatusArray(s_index).Text) <= 8.33 Then
                    lblResultDsply.Text = "PASS"
                    'lblResultDsply.BackColor = Color.White
                Else
                    lblResultDsply.Text = "FAIL"
                    'lblResultDsply.ForeColor = Color.Red
                End If
        End Select

        'highlight display status for FAILURES
        If lblResultDsply.Text = "PASS" Then
            lblResultDsply.ForeColor = Color.Black
            StatusArray(s_index).BackColor = Color.White
        Else
            lblResultDsply.ForeColor = Color.Red
            StatusArray(s_index).BackColor = Color.Red
        End If


        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55) & ",")
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & "Msec" & "," & lblResultDsply.Text.PadRight(6))
        FileWrite(tbxComment.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        GC.Collect()
        'turn off dimmer power

        'Open all Res & Cap Relays
        Disconnect_Relays_Bd1_2_3()
        Close()

    End Sub
End Class