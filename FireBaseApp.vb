Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Imports System.Web.Script.Serialization
Imports System.ComponentModel
Imports System.IO

Imports System.Configuration
Public Class FireBaseApp
    Private client As IFirebaseClient
    Private FIREBASE_API_KEY As String = ConfigurationManager.AppSettings("FIREBASE_API_KEY")
    Private FIREBASE_AUTH_DOMAIN As String = ConfigurationManager.AppSettings("FIREBASE_AUTH_DOMAIN")

    Public Sub New()
        Dim config As New FirebaseConfig() With {
            .AuthSecret = FIREBASE_API_KEY,
            .BasePath = FIREBASE_AUTH_DOMAIN
            }
        Try
            client = New FireSharp.FirebaseClient(config)
            'MessageBox.Show("connected")
        Catch ex As Exception
            MessageBox.Show("There is a problem with your internet connection. Please try again.")
        End Try
    End Sub

    Public Function InsertData(Of DataModel)(data As DataModel, path As String) As Boolean
        Dim response = client.SetAsync(path, data)
        Return response.Result.StatusCode = System.Net.HttpStatusCode.OK
    End Function

    Public Function UpdateData(Of DataModel)(data As DataModel, path As String) As Boolean
        Dim response = client.UpdateAsync(path, data)
        Return response.Result.StatusCode = System.Net.HttpStatusCode.OK
    End Function

    Public Function DeleteData(path As String) As Boolean
        Dim response = client.DeleteAsync(path)
        Return response.Result.StatusCode = System.Net.HttpStatusCode.OK
    End Function

    Public Function GetData(Of DataModel)(path As String) As Dictionary(Of String, DataModel)
        Dim response = client.Get(path)
        Return response.ResultAs(Of Dictionary(Of String, DataModel))()
    End Function

End Class
