Imports System.Data.SqlClient
Public Class PositionForm
    Sub clears()
        DataGridView1.Rows.Clear()
        txtPositionName.Clear()
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub PositionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_connection()
        clears()
        Dim da As New SqlDataAdapter("select * from tblposition", con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        For Each r As DataRow In tbl.Rows
            DataGridView1.Rows.Add(r(0), r(1))
        Next
    End Sub

    Sub EnterAdd(ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnAdd_Click(Nothing, Nothing)
            txtPositionName.Focus()
        End If
    End Sub
    Sub EnterUpdate(ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnEdit_Click(Nothing, Nothing)
            txtPositionName.Focus()
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If check_blank(txtPositionName, "Position Name") = 1 Then
            Exit Sub
        End If
        
        Dim cmd As New SqlCommand("insert into tblposition values(N'" & txtPositionName.Text & "')", con)
        cmd.ExecuteNonQuery()
        PositionForm_Load(Nothing, Nothing)
    End Sub

    Private Sub txtPositionName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPositionName.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        Else
            EnterAdd(e)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            If DataGridView1.SelectedRows.Count = 0 Then
                MsgBox("Please Select Any row to Edit")
                Exit Sub
            End If
            If comformation("Agree to Edit?") = 1 Then
                Exit Sub
            End If
            'Disable Everything
            BFEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)

            'get row index
            Dim index As Integer = DataGridView1.CurrentRow.Index


            'get value to text box and combo box

            txtPositionName.Tag = DataGridView1.SelectedRows(0).Cells(0).Value

            Dim da As New SqlDataAdapter("select positionname from tblposition where positionid='" & txtPositionName.Tag & "'", con)
            Dim tbl As New DataTable
            da.Fill(tbl)
            For Each ra As DataRow In tbl.Rows
                txtPositionName.Text = ra(0)

            Next


            
            DataGridView1.Rows.RemoveAt(index)

        Else
            'Check Null
            If check_blank(txtPositionName, "Position Name") = 1 Then
                MsgBox("Please input Position Name")
                txtPositionName.Focus()
                Exit Sub
            End If
         

            BTEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)

            Dim cmd As New SqlCommand("update tblposition set positionName=N'" & txtPositionName.Text & "' where positionID='" & txtPositionName.Tag & "'", con)
            cmd.ExecuteNonQuery()
            txtPositionName.Clear()
            PositionForm_Load(Nothing, Nothing)
        End If
    End Sub
    
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPositionName.Clear()
        BTEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)
  
        PositionForm_Load(Nothing, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteDB(DataGridView1, "tblposition", "positionid")

    End Sub
End Class