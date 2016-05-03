Public Class frmSefyllfa1

    'Cyfrif y nifer o gleifion
    Dim Cyfanswm1 As Integer = 0
    Dim Cyfanswm2 As Integer = 0
    Dim Cyfanswm3 As Integer = 0
    Dim Cyfanswm4 As Integer = 0
    'Cyfrif y nifer sy'n cael gwrthod llawdriniaeth
    Dim Gwrthod1 As Integer = 0
    Dim Gwrthod2 As Integer = 0
    Dim Gwrthod3 As Integer = 0
    Dim Gwrthod4 As Integer = 0

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

        'Rheswm am wrthod llawdriniaeth
        Dim Rheswm As String = "Rheswm am wrthod llawdriniaeth yw:"

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Canran gwrthod llawdriniaeth

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Ychwanegu at y cyfanswm
        Cyfanswm1 = Cyfanswm1 + 1
        'Penderfynu os yw'n gallu derbyn triniaeth
        If A Or B Or C Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
            'Darganfod y rheswm am wrthod
            Y_Rheswm(Rheswm, A, B, C)
            'Ychwanegu at y nifer sy'n cael ei gwrthod
            Gwrthod1 = Gwrthod1 + 1
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth, Rheswm)

    End Sub

    Private Sub btnSefyllfa2_Click(sender As Object, e As EventArgs) Handles btnSefyllfa2.Click
        'Rhaid cwrdd â phob un o'r ffactorau - AC [AND]

        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Rheswm am wrthod llawdriniaeth
        Dim Rheswm As String = "Rheswm am wrthod llawdriniaeth yw:"

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
            'Darganfod y rheswm am wrthod
            Y_Rheswm(Rheswm, A, B, C)
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth, Rheswm)
    End Sub

    Private Sub btnSefyllfa3_Click(sender As Object, e As EventArgs) Handles btnSefyllfa3.Click
        'Rhaid cwrdd ag o leiaf 2 o'r ffactorau

        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Rheswm am wrthod llawdriniaeth
        Dim Rheswm As String = "Rheswm am wrthod llawdriniaeth yw:"

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Penderfynu os yw'n gallu derbyn triniaeth
        If (A And B) Or (A And C) Or (B And C) Then 'gallu
            'If A And (B Or C) Or (B And C) Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
            'Darganfod y rheswm am wrthod
            Y_Rheswm(Rheswm, A, B, C)
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth, Rheswm)
    End Sub

    Private Sub btnSefyllfa4_Click(sender As Object, e As EventArgs) Handles btnSefyllfa4.Click
        'Rhaid cwrdd ag o leiaf 2 o'r ffactorau , neu dim yn ysmygu

        'Gosod gwerthoedd cychwynol y 3 ffactor
        Dim A As Boolean = False
        Dim B As Boolean = False
        Dim C As Boolean = False

        'Rheswm am wrthod llawdriniaeth
        Dim Rheswm As String = "Rheswm am wrthod llawdriniaeth yw:"

        'Gwerth cychwynol triniaeth
        Dim Triniaeth As Boolean = False

        'Enw'r claf
        Dim Enw As String = ""

        'Darllen mewnbwn
        Mewnbwn(Enw, A, B, C)

        'Penderfynu os yw'n gallu derbyn triniaeth
        If (A And B) Or (A And C) Or (B And C) Or B Then 'gallu
            'If A And (B Or C) Or B Then 'gallu
            Triniaeth = True
        Else 'Dim yn gallu
            Triniaeth = False
            'Darganfod y rheswm am wrthod
            Y_Rheswm(Rheswm, A, B, C)
        End If

        'Allbynnu'r penderfyniad
        Allbwn(Enw, Triniaeth, Rheswm)
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

    Private Sub Allbwn(ByVal Enw As String, ByVal Triniaeth As Boolean, ByVal Rheswm As String)
        'Allbynnu'r penderfyniad
        lblPenderfyniad.Text = "Penderfyniad: "
        If Triniaeth Then 'Gallu derbyn triniaeth
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Mae " & Enw & " yn gallu derbyn triniaeth"
        Else 'Dim yn gallu derbyn triniaeth
            lblPenderfyniad.Text = lblPenderfyniad.Text & "Nid yw " & Enw & " yn gallu derbyn triniaeth"
            'Allbynnu'r rheswm
            lblPenderfyniad.Text = lblPenderfyniad.Text & vbCrLf & Rheswm
        End If
    End Sub

    Private Sub Y_Rheswm(ByRef Rheswm As String, ByVal A As Boolean, ByVal B As Boolean, ByVal C As Boolean)
        'Rhesymau am wrthod llawdriniaeth
        Dim RheswmA As String = "Pwysau uchel"
        Dim RheswmB As String = "Ysmygu"
        Dim RheswmC As String = "Yfed yn uchel"

        'Ychwanegu rhesymau
        If Not (A) Then
            Rheswm = Rheswm & vbCrLf & RheswmA
        End If
        If Not (B) Then
            Rheswm = Rheswm & vbCrLf & RheswmB
        End If
        If Not (C) Then
            Rheswm = Rheswm & vbCrLf & RheswmC
        End If
    End Sub


End Class