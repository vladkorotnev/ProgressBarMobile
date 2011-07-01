Public Class Form1
    Private Sub endact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endact.SelectedIndexChanged
        Select Case endact.SelectedIndex
            Case 0
                msgpar.Visible = True
                url.Visible = False
                OpenFilePar.Visible = False
                browsebtn.Visible = OpenFilePar.Visible
            Case 1
                msgpar.Visible = True
                url.Visible = False
                OpenFilePar.Visible = False
                browsebtn.Visible = OpenFilePar.Visible
            Case 2
                msgpar.Visible = False
                url.Visible = True
                OpenFilePar.Visible = False
                browsebtn.Visible = OpenFilePar.Visible
            Case 3
                msgpar.Visible = False
                url.Visible = False
                OpenFilePar.Visible = True
                browsebtn.Visible = OpenFilePar.Visible
            Case 4
                msgpar.Visible = False
                url.Visible = False
                OpenFilePar.Visible = True
                browsebtn.Visible = OpenFilePar.Visible
        End Select
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.Hide()
        frmPrg.remMs = CInt(CInt(CInt(min.Text) * 60 + CInt(sec.Text)) * 1000)
        If endchk.Checked Then
            frmPrg.endact = endact.SelectedIndex
        Else
            frmPrg.endact = -1
        End If
        frmPrg.title = title.Text

        If endchk.Checked = True Then
            Select Case endact.SelectedIndex
                Case 0
                    frmPrg.endpar = msgpar.Text
                Case 1
                    frmPrg.endpar = msgpar.Text
                Case 2
                    frmPrg.endpar = url.Text
                Case 3
                    frmPrg.endpar = OpenFilePar.Text
            End Select
        End If
        frmPrg.prepareForProgressing()
        frmPrg.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        msgpar.Visible = True
        url.Visible = False
        OpenFilePar.Visible = False
        browsebtn.Visible = OpenFilePar.Visible
    End Sub

    Private Sub browsebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browsebtn.Click
        OpenFile.FileName = ""
        OpenFile.Filter = "Any file|*.*"
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "" Then
            OpenFilePar.Text = OpenFile.FileName
        End If
    End Sub
End Class
