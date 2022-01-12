Module Module1

    Public sistema = "Controle de Acesso"

    Public conn = "" 'Conectar Banco
    Public resp, diretorio As String
    Public banco = Application.StartupPath & "\Pet.accdb"
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Sub conexao()
        Try
            db = CreateObject("ADODB.Connection")

            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & banco)
            MsgBox("banco ok!!", MsgBoxStyle.Information + vbOKOnly, "ATENÇAO")
        Catch ex As Exception
            MsgBox("banco nao", MsgBoxStyle.Information + vbOKOnly, "ATENÇAO")
        End Try
    End Sub
End Module
