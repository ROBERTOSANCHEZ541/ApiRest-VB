Imports FormPokedex
Imports Newtonsoft.Json

Public Class Token
    Private Sub PbxGo_Click(sender As Object, e As EventArgs) Handles PbxGo.Click
        Dim api = New DBApi
        Dim url = "https://jsonplaceholder.typicode.com/users/1"

        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim objeto = JsonConvert.DeserializeObject(Of User)(response)

        listBox1.Text = objeto.id

        txtNombreGET.Text = objeto.name
        txtEmail.Text = objeto.email

    End Sub
    Class User
        Public Property ID As String
        Public Property name As String
        Public Property email As String

    End Class

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub
End Class