Public Class FRMConsulta

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click


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
            sql = "select * from Gerente where pet_id='" & txtIDPet.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lblData.Text = rs.Fields(1).Value
                lblhora.Text = rs.Fields(2).Value
                lblServico.Text = rs.Fields(3).Value
                'txtdata.Text = rs.Fields(1).Value
                'txthora.Text = rs.Fields(2).Value
            Else
                MsgBox("Id não cadastrado: " & txtIDPet.Text & ", Não localizado ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informo")

            End If
        Catch ex As Exception
            MsgBox("Erro de codigo, cotato com o tecnico. " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informo")
        End Try

    End Sub



    Private Sub txtIDPet_LostFocus(sender As Object, e As EventArgs) Handles txtIDPet.LostFocus



    End Sub

    Private Sub FRMConsulta_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub FRMConsulta_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexao()
    End Sub
End Class
