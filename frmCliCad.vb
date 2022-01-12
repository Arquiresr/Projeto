Public Class frmCliCad

    Private Sub btnRegCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegCliente.Click
        If ValidarForm() Then
            SalvarCliente()
            
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If txtCPF.Text = "" Then
            MsgBox("Informe o CPF do Cliente!", vbExclamation, sistema)
            txtCPF.Focus()
            result = False
        ElseIf txtNome.Text = "" Then
            MsgBox("Informe o Nome do Cliente!", vbExclamation, sistema)
            txtNome.Focus()
            result = False
        ElseIf txtEndereco.Text = "" Then
            MsgBox("Informe o Endereço do Cliente!", vbExclamation, sistema)
            txtEndereco.Focus()
            result = False
        ElseIf txtTelefone.Text = "" Then
            MsgBox("Informe o Telefone do Cliente!", vbExclamation, sistema)
            txtTelefone.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function


    Private Sub SalvarCliente()
        Dim Sql = ""



        'COLOCAR AQUI OS PARÂMETROS DO BD

        ' Using cn = New OleDbConnection(conn)
        'cn.Open()
        '  Using cmd = New OleDbCommand(Sql, cn)
        'cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
        '  cmd.Parameters.AddWithValue("@nome", txtNome.Text)
        '  cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
        '   cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text)
        '    End Using


        '  End Using
        Try
            Sql = "insert into Cliente values ('" & txtCPF.Text & "', '" & txtNome.Text & "', '" & txtEndereco.Text & "' ,'" & txtTelefone.Text & "' )"

            rs = db.Execute(UCase(Sql))
            MsgBox("Gravou", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        Catch ex As Exception
            MsgBox("não Gravou" & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        End Try

    End Sub


    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged

    End Sub
    Private Sub txtCPF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtTelefone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtEndereco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndereco.TextChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmCliCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexao()

    End Sub
End Class