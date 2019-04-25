Imports System.ComponentModel

Public Class frmOnStateSupplyCurrent
    Dim TitleStr As String

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
        'PictureBox2.Show()
        'PictureBox1.Hide()
    End Sub

    Private Sub frmOnStateSupplyCurrent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub cbx100ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx100ohm.CheckedChanged
        Dim DataValue As UInt16 : Dim Relaylist() As String
        If (cbx100ohm.Checked = True) Then
            'Disable other controls
            cbx350ohm.Enabled = False
            cbx800ohm.Enabled = False
            cbx1400ohm.Enabled = False
            'connect loads & power
            DataValue = 5
            PortATest(DataValue)
            'display title of test in Group box
            TitleStr = "HPF 100 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)


            'GetRelaysFromFile(ByVal Filename As String, ByVal RelayList() As String)
            GetRelaysFromFile("C:\temp\ON_State_Relays.txt", Relaylist, 1)
            'DisplayLoad(100)

        Else
            'Restore other controls
            cbx350ohm.Enabled = True
            cbx800ohm.Enabled = True
            cbx1400ohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx350ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx350ohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx350ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx800ohm.Enabled = False
            cbx1400ohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            TitleStr = "HPF 350 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            DisplayLoad(350)

        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx800ohm.Enabled = True
            cbx1400ohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx800ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx800ohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx800ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx350ohm.Enabled = False
            cbx1400ohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            TitleStr = "HPF 800 Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            DisplayLoad(800)

        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx350ohm.Enabled = True
            cbx1400ohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub cbx1400ohm_CheckedChanged(sender As Object, e As EventArgs) Handles cbx1400ohm.CheckedChanged
        Dim DataValue As UInt16
        If (cbx1400ohm.Checked = True) Then
            'Disable other controls
            cbx100ohm.Enabled = False
            cbx350ohm.Enabled = False
            cbx800ohm.Enabled = False
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            TitleStr = "HPF 1.4k Ohm - On-State Operation"
            DisplayTitle_Limits(TitleStr)

            DisplayLoad(1400)

        Else
            'Restore other controls
            cbx100ohm.Enabled = True
            cbx350ohm.Enabled = True
            cbx800ohm.Enabled = True
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Determine Pass/Fail status
        Dim LowValue, HighValue As String, UserEntryValue As String
        LowValue = "1.619" : HighValue = "2.081" : UserEntryValue = Val(tbxMeasurementEntry1.Text)
        'If Val(tbxMeasurementEntry1.Text) >= Val(LowValue) & Val(tbxMeasurementEntry1.Text) <= Val(HighValue) Then
        If UserEntryValue >= Val(LowValue) And UserEntryValue <= Val(HighValue) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If

        LowValue = "6.02"
        UserEntryValue = Val(tbxMeasurementEntry2.Text)
        If (lblResultDsply.Text = "PASS") Then
            If UserEntryValue >= Val(LowValue) Then
                lblResultDsply.Text = "PASS"
            Else
                lblResultDsply.Text = "FAIL"
            End If
        End If

    End Sub

    Private Sub DisplayTitle_Limits(ByVal TitleStr)
        'display title of test in Group box
        lblTestDescription.Text = TitleStr
        lblResultDsply.Text = ""
        'display limits in Group box
        tbxLimitDsply1.Text = "1.85mSec" & vbCrLf & "to" & vbCrLf & "6.02mSec"
        tbxLimitDsply2.Text = "6.02mSec Min"
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