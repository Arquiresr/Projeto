Public Class frmPetCad

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnRegPet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegPet.Click
        If ValidarForm() Then
            SalvarPet()
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If txtID.Text = "" Then
            MsgBox("Informe o ID do Pet!", vbExclamation, sistema)
            txtID.Focus()
            result = False
        ElseIf txtNomePet.Text = "" Then
            MsgBox("Informe o Nome do Pet!", vbExclamation, sistema)
            txtNomePet.Focus()
            result = False
        ElseIf txtIdade.Text = "" Then
            MsgBox("Informe a Idade do Pet!", vbExclamation, sistema)
            txtIdade.Focus()
            result = False
        ElseIf txtPeso.Text = "" Then
            MsgBox("Informe o Peso do Pet!", vbExclamation, sistema)
            txtPeso.Focus()
            result = False
        ElseIf txtRaca.Text = "" Then
            MsgBox("Informe a Raça do Pet!", vbExclamation, sistema)
            txtRaca.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Sub SalvarPet()
        Dim Sql = ""



        'COLOCAR AQUI OS PARÂMETROS DO BD

        ' Using cn = New OleDbConnection(conn)
        'cn.Open()
        'Using cmd = New OleDbCommand(Sql, cn)
        ' cmd.Parameters.AddWithValue("@nome", txtNomePet.Text)
        'cmd.Parameters.AddWithValue("@raca", txtRaca.Text)
        '  cmd.Parameters.AddWithValue("@peso", txtPeso.Text)
        ' cmd.Parameters.AddWithValue("@idade", txtIdade.Text)
        '  cmd.Parameters.AddWithValue("@id", txtID.Text)
        ' End Using


        '  End Using
        Try
            Sql = "insert into Animal values ('" & txtID.Text & "', '" & txtNomePet.Text & "', '" & txtIdade.Text & "' ,'" & txtRaca.Text & "' ,'" & txtPeso.Text & "'  )"

            rs = db.Execute(UCase(Sql))
            MsgBox("Gravou", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        Catch ex As Exception
            MsgBox("não Gravou" & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇão")
        End Try
    End Sub

    Private Sub frmPetCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call conexao()
        'Call conexao()
        Call conexao()


    End Sub
End Class