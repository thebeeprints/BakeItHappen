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
            .AuthSecret = "LsBgkAmK485VYAW1mkoRw1gROtA6dV1FwkncTQzg",
            .BasePath = "https://testing-firebase-b6205-default-rtdb.asia-southeast1.firebasedatabase.app/"
            }
        Try
            client = New FireSharp.FirebaseClient(config)
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
    S
    Public Function DeleteData(path As String) As Boolean
        Dim response = client.DeleteAsync(path)
        Return response.Result.StatusCode = System.Net.HttpStatusCode.OK
    End Function

    Public Function GetData(Of DataModel)(path As String) As Dictionary(Of String, DataModel)
        Dim response = client.Get(path)
        Return response.ResultAs(Of Dictionary(Of String, DataModel))()
    End Function

End Class
