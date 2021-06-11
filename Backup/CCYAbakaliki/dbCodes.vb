Imports System.Data.SqlClient
Public Class dbCodes
    Public cn As SqlConnection
    Public SysDate As DateTime
    Public Sub dbconnect()
        Try
            cn = New SqlConnection("server=localhost; uid=sa; pwd=hamplustech; database=ChristChosenYouth")
            If cn.State = Data.ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub dbtime()
        Try
            dbconnect()
            Dim cmd = New SqlCommand("select GetDate()", cn)
            SysDate = cmd.ExecuteScalar
            cmd.Dispose()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class
