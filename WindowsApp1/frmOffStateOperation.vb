Imports System.ComponentModel

Public Class frmOffStateOperation
    Dim intTestNum As Integer
    Dim DataValue As UInt16 : Dim RelayList(5) As String : Dim strLine As String
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file
    Dim PbxImageSelect As Integer           'cycle thru docs


    Private Sub frmOffStateOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        PbxImageSelect = 1          'init doc to show
        btnInfo_Click(sender, e)    'force update

    End Sub

    Private Sub frmOffStateOperation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
        Disconnect_Relays_Bd1_2()
    End Sub

    Private Sub cbx10ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx10ohm.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays


        Else
            'Restore other controls
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

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
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True

        End If
    End Sub

    Private Sub cbx400ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx400ohm.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays


        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
        End If
    End Sub

    Private Sub cbx3kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx3kohm.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
        End If
    End Sub

    Private Sub cbx8kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx8kohm.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx15kohm.Enabled = True
        End If
    End Sub

    Private Sub cbx15kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx15kohm.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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
            'Close_Relays(LPF_CapRelays)      'Capacitor relays


        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If blnTestTitleDone = False Then
            FileWrite("Off-State Operation")
            blnTestTitleDone = True
        End If

        'Determine Pass/Fail status
        If Val(tbxLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)

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
        tbxResRly.Text = strLine

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
End Class