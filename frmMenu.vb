Public Class frmMenu

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        frmCliCad.Show()

    End Sub

    Private Sub PetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetToolStripMenuItem.Click
        frmPetCad.Show()
    End Sub

    Private Sub BanhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanhoToolStripMenuItem.Click
        frmAgendamento.Show()
    End Sub

    Private Sub AgendamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendamentoToolStripMenuItem.Click
        frmConsulta.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CadastrarUsuárioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class
