Public Class frmSefyllfa1

   
    Private Sub frmSefyllfa1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gosod gwerthoedd cychwynol y blwch
        chk_A_PwysauNormal.Checked = False
        chk_B_DimSmygu.Checked = False
        chk_C_Yfed.Checked = False
    End Sub

    Private Sub btnSefyllfa1_Click(sender As Object, e As EventArgs) Handles btnSefyllfa1.Click
        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Darllen y mewnbwn
        A = chk_A_PwysauNormal.Checked
        B = chk_B_DimSmygu.Checked
        C = chk_C_Yfed.Checked

        'MsgBox(A & " " & B & " " & C & "")
        'Penderfynu os yw'n gallu derbyn triniaeth
        If A Or B Or C Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
        End If
        lblPenderfyniad.Text = "Penderfyniad: "
        If Triniaeth Then
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Gallu derbyn triniaeth"
        Else
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Dim yn gallu derbyn triniaeth"
        End If

    End Sub
End Class