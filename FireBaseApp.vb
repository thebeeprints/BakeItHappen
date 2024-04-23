Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Imports System.Web.Script.Serialization
Imports System.ComponentModel
Imports System.IO
Public Class FireBaseApp
    Private client As IFirebaseClient

    Public Sub New()
        Dim config As New FirebaseConfig() With {
            .AuthSecret = "vZtchRUFM6oKj3tHQrHaiIIUVnNxbNUQZc42eoeB",
            .BasePath = "https://bakeithappen-db-default-rtdb.asia-southeast1.firebasedatabase.app/"
            }
        Try
            client = New FireSharp.FirebaseClient(config)
        Catch ex As Exception
            MessageBox.Show("There is a problem with your internet connection. Please try again.")
        End Try
    End Sub
End Class
