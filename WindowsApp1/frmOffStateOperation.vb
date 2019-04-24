Imports System.ComponentModel

Public Class frmOffStateOperation

    Private Sub frmOffStateOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
    End Sub

    Private Sub frmOffStateOperation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub cbx10ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx10ohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx10ohm.Checked = True) Then
            'Disable other controls
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 10 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "15mA Max"

            DisplayLoad(10)


        Else
            'Restore other controls
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
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
        If (cbx40ohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 40 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "15mA Max"

            DisplayLoad(40)
        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx400ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx400ohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx400ohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest1(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 400 ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "10.1mA Max"

            DisplayLoad(400)

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest1(DataValue)
        End If
    End Sub

    Private Sub cbx3kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx3kohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx3kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx8kohm.Enabled = False
            cbx15kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 3k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "6mA Max"

            DisplayLoad(3000)

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx8kohm.Enabled = True
            cbx15kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx8kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx8kohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx8kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx15kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 8k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "4.8mA Max"

            DisplayLoad(8000)

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx15kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx15kohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx15kohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx15kohm.Checked = True) Then
            'Disable other controls
            cbx10ohm.Enabled = False
            cbx40ohm.Enabled = False
            cbx400ohm.Enabled = False
            cbx3kohm.Enabled = False
            cbx8kohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test in Group box
            lblTestDescription.Text = "Off State Operation - 15k ohm"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "4.5mA Max"

            DisplayLoad(15000)

        Else
            'Restore other controls
            cbx10ohm.Enabled = True
            cbx40ohm.Enabled = True
            cbx400ohm.Enabled = True
            cbx3kohm.Enabled = True
            cbx8kohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Determine Pass/Fail status
        If Val(tbxLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If
    End Sub

    Private Sub DisplayLoad(ByVal Num As Integer)
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "HPF Res"
        lblCap.Text = ""        '"Overload LPF Cap"
        'update textbox values
        tbxWatt.Text = ""       'WattageSelection(Index)
        tbxRes.Text = Num       'OVLDLPF_Res(Index)
        tbxCap.Text = ""        'OVLDLPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(OVLDLPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub
End Class