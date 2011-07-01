Public Class frmPrg
    Public remMs As Integer
    Public title As String
    Public style As Integer
    Public endact As Integer
    Public endpar As String
    Dim Mnogotochie As String

    Sub prepareForProgressing()
        If title <> "developers" And title <> "DEVELOPERS" And title <> "Developers" Then
            Me.Text = title
            Mnogotochie = ""
        Else
            Mnogotochie = " "
        End If
        ProgressBar1.Maximum = 100
        Timer1.Interval = remMs / 100
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            Timer1.Enabled = False
            Select Case endact
                Case -1
                    Form1.Close()
                    Me.Close()
                    Application.Exit()
                Case 0
                    MsgBox(endpar, MsgBoxStyle.OkOnly, title)
                    Form1.Close()
                    Me.Close()
                    Application.Exit()
                Case 1
                    Notification.Text = endpar
                    Notification.Caption = title
                    Notification.Visible = True
                    Me.ControlBox = True
                Case 2
                    ' Shell("explorer " + endpar)
                    ass.Visible = True
                    ass.Navigate(New Uri(endpar))
                    Me.ControlBox = True
            End Select

        End If
        If title <> "developers" And title <> "DEVELOPERS" And title <> "Developers" Then
            Select Case Mnogotochie
                Case ""
                    Mnogotochie = "."
                Case "."
                    Mnogotochie = ".."
                Case ".."
                    Mnogotochie = "..."
                Case "..."
                    Mnogotochie = ""
            End Select
            On Error Resume Next
            Me.Text = title + Mnogotochie
        Else
            endact = 0
            endpar = "Ballmer = LOL :)"
            Select Case Mnogotochie
                Case " "
                    Mnogotochie = "Developers"
                Case "Developers"
                    Mnogotochie = "Developers, Developers"
                Case "Developers, Developers"
                    Mnogotochie = "Developers, Developers, Developers"
                Case "Developers, Developers, Developers"
                    Mnogotochie = "Developers, Developers, Developers, Developers"
                Case "Developers, Developers, Developers, Developers"
                    Mnogotochie = " "
            End Select
            On Error Resume Next
            Me.Text = Mnogotochie
        End If
    End Sub

    Private Sub frmPrg_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub frmPrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class