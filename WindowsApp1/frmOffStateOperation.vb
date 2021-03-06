﻿Imports System.ComponentModel

Public Class frmOffStateOperation
    Dim intTestNum As Integer
    Dim DataValue As UInt16 : Dim RelayList(5) As String : Dim strLine As String
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file
    Dim PbxImageSelect As Integer           'cycle thru docs

    Dim StatusArray(5) As Label             'array of status textbox for display results
    Dim s_index As Integer                  'index for array of textboxes

    Private Sub frmOffStateOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        PbxImageSelect = 1          'init doc to show
        btnInfo_Click(sender, e)    'force update

        StatusArray(0) = lblStatus0
        StatusArray(1) = lblStatus1
        StatusArray(2) = lblStatus2
        StatusArray(3) = lblStatus3
        StatusArray(4) = lblStatus4
        StatusArray(5) = lblStatus5

        'select button test status invisible until test done
        For s_index = 0 To 5
            StatusArray(s_index).Visible = False
        Next

    End Sub

    Private Sub frmOffStateOperation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub cbx10ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx10ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 0                             'associate the label to this test
        'StatusArray(s_index).Visible = True     'show when test becomes active

        If (cbx10ohm.Checked = True) Then
            'Disable other controls
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 10 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "15mA Max"

            intTestNum = 1      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer


        Else
            'Restore other controls
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

            'keep entered value
            'StatusArray(s_index).Text = tbxMeasurementEntry.Text

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

            'display result in Group box
            'Determine Pass/Fail status
            If Val(tbxLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
                lblResultDsply.Text = "PASS"
            Else
                lblResultDsply.Text = "FAIL"
            End If

        End If
    End Sub

    Private Sub cbx40ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx40ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 1                          'associate the label to this test
        'StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbx40ohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 40 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "15mA Max"

            intTestNum = 2      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

        End If
    End Sub

    Private Sub cbx400ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx400ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 2                           'associate the label to this test
        'StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbx400ohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 400 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "10.1mA Max"

            intTestNum = 3      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

        End If
    End Sub

    Private Sub cbx3kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx3kohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 3                           'associate the label to this test
        'StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbx3kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 3k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "6mA Max"

            intTestNum = 4      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

        End If
    End Sub

    Private Sub cbx8kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx8kohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 4                           'associate the label to this test
        'StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbx8kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx15kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 8k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "4.8mA Max"

            intTestNum = 5      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx15kohm.Enabled = True

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

        End If
    End Sub

    Private Sub cbx15kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx15kohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 5                           'associate the label to this test
        'StatusArray(s_index).Visible = True  'show when test becomes active

        If (cbx15kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 15k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "4.5mA Max"

            intTestNum = 6      'Index value for this test
            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_OFF_State_Relays, RelayList, strLine, intTestNum)
            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True

            'clear Measurement Entry
            tbxMeasurementEntry.Text = ""
            tbxComment.Text = ""

        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If blnTestTitleDone = False Then
            FileWrite("Off-State Operation")
            blnTestTitleDone = True
        End If

        'Entry Parameter check
        If IsNumeric(tbxMeasurementEntry.Text) = False Then
            MsgBox("must enter a numeric value")
            Return
        End If

        StatusArray(s_index).Text = tbxMeasurementEntry.Text     'display result status near select button - save test status
        StatusArray(s_index).Visible = True     'show when test becomes active

        Select Case s_index
            Case 0, 1
                If Val(StatusArray(s_index).Text) <= 15 Then
                    lblResultDsply.Text = "PASS"
                Else
                    lblResultDsply.Text = "FAIL"
                End If
            Case 2
                If Val(StatusArray(s_index).Text) <= 10.1 Then
                    lblResultDsply.Text = "PASS"
                Else
                    lblResultDsply.Text = "FAIL"
                End If
            Case 3
                If Val(StatusArray(s_index).Text) <= 6 Then
                    lblResultDsply.Text = "PASS"
                Else
                    lblResultDsply.Text = "FAIL"
                End If
            Case 4
                If Val(StatusArray(s_index).Text) <= 4.8 Then
                    lblResultDsply.Text = "PASS"
                Else
                    lblResultDsply.Text = "FAIL"
                End If
            Case 5
                If Val(StatusArray(s_index).Text) <= 4.5 Then
                    lblResultDsply.Text = "PASS"
                Else
                    lblResultDsply.Text = "FAIL"
                End If
        End Select

        ''Determine Pass/Fail status
        'If Val(tbxLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
        '    lblResultDsply.Text = "PASS"
        'Else
        '    lblResultDsply.Text = "FAIL"
        'End If

        'highlight display status for FAILURES
        If lblResultDsply.Text = "PASS" Then
            lblResultDsply.ForeColor = Color.Black
            StatusArray(s_index).BackColor = Color.White
            StatusArray(s_index).ForeColor = Color.Black
        Else
            lblResultDsply.ForeColor = Color.Red
            StatusArray(s_index).ForeColor = Color.Red
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55) & ",")
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & "mA" & "," & lblResultDsply.Text.PadRight(6))
        FileWrite("," & tbxComment.Text)

    End Sub

    Private Sub DisplayLoad(ByRef RelayList() As String, ByVal strLine As String)  ', ByVal Num As Integer)
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = ""       '"Watts"
        lblRes.Text = "HPF Res"
        lblCap.Text = ""        '"Overload LPF Cap"
        'update textbox values
        tbxWatt.Text = ""       'WattageSelection(Index)
        tbxRes.Text = RelayList(0)       'OVLDLPF_Res(Index)
        tbxCap.Text = ""        'OVLDLPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"

        'display relays
        'Dim textline As String = ""
        'Display_Relays(HPF_ResRelays, textline)
        'tbxResRly.Text = strLine

        'only display relays - NOT resistance value
        Dim textline As String = ""
        Display_Relays(RelayList, textline)
        tbxResRly.Text = textline

        'Display_Relays(OVLDLPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Select Case PbxImageSelect
            Case 1
                pbxImage1.Visible = True
                pbxImage2.Visible = False
                pbxImage3.Visible = False
                PbxImageSelect = 2
            Case 2
                pbxImage1.Visible = False
                pbxImage2.Visible = True
                pbxImage3.Visible = False
                PbxImageSelect = 3
            Case 3
                pbxImage1.Visible = False
                pbxImage2.Visible = False
                pbxImage3.Visible = True
                PbxImageSelect = 1

        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
        Disconnect_Relays_Bd1_2_3()
        Close()

    End Sub
End Class