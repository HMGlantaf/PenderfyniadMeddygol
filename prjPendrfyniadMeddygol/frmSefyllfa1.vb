Public Class frmSefyllfa1

    Private Sub frmSefyllfa1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gosod gwerthoedd cychwynol y blwch
        chk_A_PwysauNormal.Checked = False
        chk_B_DimSmygu.Checked = False
        chk_C_Yfed.Checked = False
    End Sub

    Private Sub btnSefyllfa1_Click(sender As Object, e As EventArgs) Handles btnSefyllfa1.Click
        'Rhaid cwrdd ag un ffactor - NEU [OR]
        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Penderfynu os yw'n gallu derbyn triniaeth
        If A Or B Or C Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth)

    End Sub

    Private Sub btnSefyllfa2_Click(sender As Object, e As EventArgs) Handles btnSefyllfa2.Click
        'Rhaid cwrdd â phob un o'r ffactorau - AC [AND]

        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Penderfynu os yw'n gallu derbyn triniaeth
        If A And B And C Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth)
    End Sub

    Private Sub btnSefyllfa3_Click(sender As Object, e As EventArgs) Handles btnSefyllfa3.Click
        'Rhaid cwrdd â phob un o'r ffactorau - AC [AND]

        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Penderfynu os yw'n gallu derbyn triniaeth
        If  Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth)
    End Sub

    Private Sub Mewnbwn(ByRef Enw As String, ByRef A As Boolean, ByRef B As Boolean, ByRef C As Boolean)
        'Darllen y mewnbwn
        'Enw
        Enw = txtEnw.Text

        'Ffactorau
        A = chk_A_PwysauNormal.Checked
        B = chk_B_DimSmygu.Checked
        C = chk_C_Yfed.Checked

    End Sub

    Private Sub Allbwn(ByVal Enw As String, ByVal Triniaeth As Boolean)
        'Allbynnu'r penderfyniad
        lblPenderfyniad.Text = "Penderfyniad: "
        If Triniaeth Then 'Gallu derbyn triniaeth
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Mae " & Enw & " yn gallu derbyn triniaeth"
        Else 'Dim yn gallu derbyn triniaeth
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Nid yw " & Enw & " yn gallu derbyn triniaeth"
        End If
    End Sub

End Class