Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Dim userc As String
        'Dim senhac As String
        'userc = "admin"
        ' senhac = "admin"

        ''If txtSenha.Text = senhac Then
        ' frmMenu.Show()
        ' Else
        ' MsgBox("Login Inválido", vbExclamation)
        ' txtUsuario.Focus()



        ' End If
        Try
            sql = "select * from Cliente where (Nome='" & txtUsuario.Text & "') and Cpf = '" & txtSenha.Text & "' "
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("lOGADO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
                frmMenu.Show()
            Else
                MsgBox("Não Logado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
            End If
        Catch ex As Exception
            MsgBox("ERRO, CONTATE COM O ADM", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        End Try


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexao()
    End Sub
End Class