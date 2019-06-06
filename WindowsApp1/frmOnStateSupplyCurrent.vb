Imports System.ComponentModel

Public Class frmOnStateSupplyCurrent
    Dim TitleStr As String
    Dim intTestNum As Integer
    Dim DataValue As UInt16 : Dim RelayList(5) As String : Dim strLine As String
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file

    Dim StatusArray(3) As Label             'array of status textbox for display results
    Dim s_index As Integer                  'index for array of textboxes

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If PictureBox2.Visible Then
            PictureBox2.Hide()
            PictureBox1.Show()
        Else
            PictureBox1.Hide()
            PictureBox2.Show()
        End If
    End Sub

    Private Sub frmOnStateSupplyCurrent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Show()
        PictureBox2.Hide()

        StatusArray(0) = lblStatus0
        StatusArray(1) = lblStatus1
        StatusArray(2) = lblStatus2
        StatusArray(3) = lblStatus3

        'select button test status invisible until test done
        For s_index = 0 To 3
            StatusArray(s_index).Visible = False
        Next

        'hide Test button & User Guide until test load selected
        btnTest.Visible = False
        lblUserGuide.Visible = False

    End Sub

    Private Sub frmOnStateSupplyCurrent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub cbx100ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx100ohm.CheckedChanged
        'Dim DataValue As UInt16 : Dim RelayList(5) As String : Dim strLine As String

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 0                             'associate the label to this test
        'StatusArray(s_index).Visible = True     'show when test becomes active

        If (cbx100ohm.Checked = True) Then
            'Disable other controls
            cbx350ohm.Enabled = False
            cbx800ohm.Enabled = False
            cbx1400ohm.Enabled = False

            'display title of test in Group box
            TitleStr = "HPF 100 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            intTestNum = 1      'Index value for this test

            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_ON_State_Relays, RelayList, strLine, intTestNum)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(ShuntRelay)    'Shunt - bypass dimmer
            Close_Relays(PwrRelay)      'Enable AC power to dimmer


            'Inform user of Peak Current Adjustment and Press Test button when ready
            UserMessageDisplay(intTestNum)

            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            ''**** Or This
            ''Test is done with HPF Minimum load - close Relays
            'Close_Relays(MinHPF_ResRelays)      'Resistor relays
            ''Display
            'DisplayHPFLoad(intTestNum)

        Else
            'Restore other controls
            cbx350ohm.Enabled = True
            cbx800ohm.Enabled = True
            cbx1400ohm.Enabled = True

            'reset the Measurement checkboxes
            cbxSelect1.Checked = False
            cbxSelect2.Checked = False
            'force user to select another test before checking measurement result
            s_index = 4

            'hide Test button & User Guide until test load selected
            btnTest.Visible = False
            lblUserGuide.Visible = False

        End If
    End Sub

    Private Sub cbx350ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx350ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 1                             'associate the label to this test
        'StatusArray(s_index).Visible = True     'show when test becomes active

        If (cbx350ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx800ohm.Enabled = False
            cbx1400ohm.Enabled = False

            TitleStr = "HPF 350 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            intTestNum = 2      'Index value for this test

            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_ON_State_Relays, RelayList, strLine, intTestNum)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(ShuntRelay)    'Shunt - bypass dimmer
            Close_Relays(PwrRelay)      'Enable AC power to dimmer


            'Inform user of Peak Current Adjustment and Press Test button when ready
            UserMessageDisplay(intTestNum)

            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            ''**** Or This
            ''Test is done with HPF Minimum load - close Relays
            'Close_Relays(MinHPF_ResRelays)      'Resistor relays
            ''Display
            'DisplayHPFLoad(intTestNum)

        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx800ohm.Enabled = True
            cbx1400ohm.Enabled = True

            'reset the Measurement checkboxes
            cbxSelect1.Checked = False
            cbxSelect2.Checked = False
            'force user to select another test before checking measurement result
            s_index = 4

            'hide Test button & User Guide until test load selected
            btnTest.Visible = False
            lblUserGuide.Visible = False

        End If
    End Sub

    Private Sub cbx800ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx800ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 2                             'associate the label to this test
        'StatusArray(s_index).Visible = True     'show when test becomes active

        If (cbx800ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx350ohm.Enabled = False
            cbx1400ohm.Enabled = False

            TitleStr = "HPF 800 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            intTestNum = 3      'Index value for this test

            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_ON_State_Relays, RelayList, strLine, intTestNum)

            'close Relays - connect loads & power
            Close_Relays(RelayList)      'Resistor relays
            Close_Relays(ShuntRelay)    'Shunt - bypass dimmer
            Close_Relays(PwrRelay)      'Enable AC power to dimmer

            'Inform user of Peak Current Adjustment and Press Test button when ready
            UserMessageDisplay(intTestNum)

            'Display load/Relay info
            DisplayLoad(RelayList, strLine)

            ''Test is done with HPF Minimum load - close Relays
            'Close_Relays(MinHPF_ResRelays)      'Resistor relays
            ''Display
            'DisplayHPFLoad(intTestNum)

        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx350ohm.Enabled = True
            cbx1400ohm.Enabled = True

            'reset the Measurement checkboxes
            cbxSelect1.Checked = False
            cbxSelect2.Checked = False
            'force user to select another test before checking measurement result
            s_index = 4

            'hide Test button & User Guide until test load selected
            btnTest.Visible = False
            lblUserGuide.Visible = False

        End If
    End Sub

    Private Sub cbx1400ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx1400ohm.CheckedChanged

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2_3()

        'do not show until test result done
        s_index = 3                             'associate the label to this test
        'StatusArray(s_index).Visible = True     'show when test becomes active

        If (cbx1400ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx350ohm.Enabled = False
            cbx800ohm.Enabled = False

            TitleStr = "HPF 1.4k Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            intTestNum = 4      'Index value for this test

            'Retrieve Relay connections for Ron = 100 ohms
            GetRelaysFromFile(FileLoc_ON_State_Relays, RelayList, strLine, intTestNum)

            'close Relays - connect loads & power
            Close_Relays(RelayList)         'Resistor relays
            Close_Relays(ShuntRelay)        'Shunt - bypass dimmer
            Close_Relays(PwrRelay)          'Enable AC power to dimmer

            'Inform user of Peak Current Adjustment and Press Test button when ready
            UserMessageDisplay(intTestNum)

            'Display load/Relay info
            DisplayLoad(RelayList, strLine)



            ''Test is done with HPF Minimum load - close Relays
            'Close_Relays(MinHPF_ResRelays)      'Resistor relays
            ''Display
            'DisplayHPFLoad(intTestNum)


        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx350ohm.Enabled = True
            cbx800ohm.Enabled = True

            'reset the Measurement checkboxes
            cbxSelect1.Checked = False
            cbxSelect2.Checked = False
            'force user to select another test before checking measurement result
            s_index = 4

            'hide Test button & User Guide until test load selected
            btnTest.Visible = False
            lblUserGuide.Visible = False
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'verify a test is selected
        If s_index > 3 Then
            MsgBox("Must select a test setup option")
            Return
        End If

        StatusArray(s_index).Visible = True     'show when test becomes active

        If cbxSelect1.Checked = True And cbxSelect2.Checked = True Then
            lblResultDsply.Text = "PASS"
            StatusArray(s_index).Text = "PASS"
            StatusArray(s_index).ForeColor = Color.Black
        Else
            lblResultDsply.Text = "FAIL"
            StatusArray(s_index).Text = "FAIL"
            StatusArray(s_index).ForeColor = Color.Red
        End If





        'StatusArray(s_index).Text = tbxMeasurementEntry.Text     'display result status near select button - save test status

        'Select Case s_index
        '    Case 0
        '        If Val(StatusArray(s_index).Text) <= 15 Then
        '            lblResultDsply.Text = "PASS"
        '        Else
        '            lblResultDsply.Text = "FAIL"
        '        End If
        '    Case 1
        '        If Val(StatusArray(s_index).Text) <= 10.1 Then
        '            lblResultDsply.Text = "PASS"
        '        Else
        '            lblResultDsply.Text = "FAIL"
        '        End If
        '    Case 2
        '        If Val(StatusArray(s_index).Text) <= 6 Then
        '            lblResultDsply.Text = "PASS"
        '        Else
        '            lblResultDsply.Text = "FAIL"
        '        End If
        '    Case 3
        '        If Val(StatusArray(s_index).Text) <= 4.8 Then
        '            lblResultDsply.Text = "PASS"
        '        Else
        '            lblResultDsply.Text = "FAIL"
        '        End If
        'End Select


        ''Determine Pass/Fail status
        'Dim LowValue, HighValue As String, UserEntryValue As String
        'LowValue = "1.619" : HighValue = "2.081" : UserEntryValue = Val(tbxMeasurementEntry.Text)
        ''If Val(tbxMeasurementEntry1.Text) >= Val(LowValue) & Val(tbxMeasurementEntry1.Text) <= Val(HighValue) Then
        'If UserEntryValue >= Val(LowValue) And UserEntryValue <= Val(HighValue) Then
        '    lblResultDsply.Text = "PASS"
        'Else
        '    lblResultDsply.Text = "FAIL"
        'End If

        'LowValue = "6.02"
        'UserEntryValue = Val(tbxMeasurementEntry2.Text)
        'If (lblResultDsply.Text = "PASS") Then
        '    If UserEntryValue >= Val(LowValue) Then
        '        lblResultDsply.Text = "PASS"
        '    Else
        '        lblResultDsply.Text = "FAIL"
        '    End If
        'End If

        If blnTestTitleDone = False Then
            FileWrite("On-State Operation Test")
            blnTestTitleDone = True
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55) & ",")
        'FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)

    End Sub

    Private Sub DisplayTitle_Limits(ByVal TitleStr)
        'display title of test in Group box
        lblTestDescription.Text = TitleStr
        lblResultDsply.Text = ""
        'display limits in Group box
        tbxLimitDsply1.Text = "1.85mSec" & vbCrLf & "to" & vbCrLf & "6.02mSec"
        tbxLimitDsply2.Text = "6.02mSec Min"
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

    '******* test out ******
    Private Sub DisplayHPFLoad(ByRef intTestNum As Integer)
        Dim strLine As String

        'Update Test Status
        Select Case intTestNum
            Case 1
                strLine = "HPF 100 Ohm - On-State Operation"
            Case 2
                strLine = "HPF 350 Ohm - On-State Operation"
            Case 3
                strLine = "HPF 800 Ohm - On-State Operation"
            Case Else
                strLine = "HPF 1400 Ohm - On-State Operation"
        End Select

        lblTestDescription.Text = strLine
        'lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        'tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min HPF Res"
        lblCap.Text = ""
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""
        'display titles to relays
        lblResRly.Text = "Min Res Rly"
        lblCapRly.Text = ""
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        'close Relays
        Close_Relays(MinHPF_ResRelays)      'Resistor relays
        'Close_Relays(MinLPF_CapRelays)      'Capacitor relays

        'Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = ""

    End Sub

    Private Sub frmOnStateSupplyCurrent_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Disconnect_Relays_Bd1_2_3()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
        Disconnect_Relays_Bd1_2_3()
        Close()

    End Sub

    Private Sub UserMessageDisplay(ByRef intTestNum As Integer)

        'setup peak current to display for user
        Dim strPkCurrent As String
        Select Case intTestNum
            Case 1
                strPkCurrent = "100mA"
            Case 2
                strPkCurrent = "50mA"
            Case 3
                strPkCurrent = "40mA"
            Case Else
                strPkCurrent = "30mA"
        End Select
        'display button with text instructing user to adjust R2 peak current
        'display peak current to adjust to
        lblUserGuide.Text = "Dimmer is Shunted, the HPF load connected" _
                & vbCrLf & "Adjust R2 for peak current of " & strPkCurrent _
                & vbCrLf & "* Press Test button when done *"

        'Unhide Test button & User Guide text
        btnTest.Visible = True
        lblUserGuide.Visible = True
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'User has adjusted the peak current for the selected load
        'Remove the shunt and connect the dimmer to the load
        'user will verify dimmer operation and check min & max dimmer levels

        Open_Relays(ShuntRelay)         'remove Shunt

        'display peak current to adjust to
        lblUserGuide.Text = "Dimmer is connected" _
                & vbCrLf & "Verify Operation, Min & Max levels "

        btnTest.Visible = False

    End Sub
End Class