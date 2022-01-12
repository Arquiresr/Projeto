Public Class frmAgendamento

    Private Sub chkBanho_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        Try
            sql = "insert into Gerente values ('" & txtIDPet.Text & "', '" & txtData.Text & "', '" & txtHora.Text & "', '" & txtServiço.Text & "')"

            rs = db.Execute(UCase(sql))
            MsgBox("Gravou", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        Catch ex As Exception
            MsgBox("não Gravou" & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        End Try

    End Sub

    Private Sub frmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexao()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServiço.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class