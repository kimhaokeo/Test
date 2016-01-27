Imports System.Data.SqlClient
Module Module1
    'Con
    Public Sub ConPassword(ByVal pass As String)
        PassForCon = pass
    End Sub
    Public Sub ConDB(ByVal DB As String)
        DBForCon = DB
    End Sub
    Public PassForCon As String
    Public DBForCon As String
    Public con As New SqlConnection("server=localhost\SQLEXPRESS;User ID=sa;Password=" & PassForCon & ";Database=" & DBForCon & "")
    'Con End

    'Check_Connection
    Sub check_connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    'Check_Connection End




End Module
