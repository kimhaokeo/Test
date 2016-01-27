Imports System.Data.SqlClient
Public Class StaffInfoForm
    Sub clears()
        txtPassword.Clear()
        txtSalary.Value = 0
        txtStaffName.Clear()
        txtUserName.Clear()
        cboGender.SelectedIndex = 0
        cboPosition.SelectedIndex = 0
    End Sub
    Sub EnterAdd(ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnAdd_Click(Nothing, Nothing)
            txtStaffName.Focus()
        End If
    End Sub
    Sub EnterUpdate(ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnEdit_Click(Nothing, Nothing)
            txtStaffName.Focus()
        End If
    End Sub
    Sub EnterSearch(ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnSearch_Click(Nothing, Nothing)
            txtStaffName.Focus()
        End If
    End Sub
    Private Sub StaffInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PositionDataSet.tblPosition' table. You can move, or remove it, as needed.
        Me.TblPositionTableAdapter.Fill(Me.PositionDataSet.tblPosition)
        check_connection()
        DataGridViewX1.Rows.Clear()
        clears()
        Dim da As New SqlDataAdapter("select * from tblstaff", con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        For Each r As DataRow In tbl.Rows
            Dim cmd As New SqlCommand("select positionname from tblposition where positionid=" & r(4) & "", con)
            DataGridViewX1.Rows.Add(r(0), r(1), r(2), r(3), cmd.ExecuteScalar, r(5), r(6))
        Next

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteDB(DataGridViewX1, "tblStaff", "staffid")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If check_blank(txtStaffName, "Staff Name") = 1 Then
            Exit Sub
        End If
        If check_blank(txtUserName, "User Name") = 1 Then
            Exit Sub
        End If
        If check_blank(txtPassword, "Password") = 1 Then
            Exit Sub
        End If
        If txtSalary.Value <= 0 Then
            MsgBox("Invalidate Salary")
            txtSalary.Focus()
            Exit Sub
        End If
        Dim cmdTest As New SqlCommand("select * from tblstaff where lower(username)='" & txtUserName.Text.ToLower & "'", con)
        If cmdTest.ExecuteScalar >= 1 Then
            MsgBox("Dumplicate Username")
            txtUserName.SelectAll()
            txtUserName.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlCommand("insert into tblStaff(StaffName,Gender,Salary,Position,UserName,Password) values(N'" & txtStaffName.Text & "','" & cboGender.SelectedItem.ToString & "','" & txtSalary.Text & "','" & cboPosition.SelectedValue & "',N'" & txtUserName.Text & "','" & txtPassword.Text & "')", con)
        cmd.ExecuteNonQuery()
        StaffInfoForm_Load(Nothing, Nothing)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtStaffName.Text <> Nothing Or txtUserName.Text <> Nothing Then
            If txtStaffName.Text <> Nothing And txtUserName.Text <> Nothing Then
                Dim da As New SqlDataAdapter("Select * from tblstaff where lower(username)='" & txtUserName.Text.ToLower & "' and lower(staffname)='" & txtStaffName.Text.ToLower & "'", con)
                Dim tbl As New DataTable
                da.Fill(tbl)
                DataGridViewX1.Rows.Clear()
                DataGridViewX1.Rows.Add(tbl(0)(0), tbl(0)(1), tbl(0)(2), tbl(0)(3), tbl(0)(4), tbl(0)(5), tbl(0)(6))
                Exit Sub
            ElseIf txtStaffName.Text <> Nothing Then
                If txtUserName.Text = Nothing Then
                    Dim da1 As New SqlDataAdapter("Select * from tblstaff where lower(staffname)='" & txtStaffName.Text.ToLower & "'", con)
                    Dim tbl1 As New DataTable
                    da1.Fill(tbl1)
                    DataGridViewX1.Rows.Clear()
                    For Each r1 As DataRow In tbl1.Rows
                        DataGridViewX1.Rows.Add(r1(0), r1(1), r1(2), r1(3), r1(4), r1(5), r1(6))
                    Next
                    Exit Sub
                Else
                    MsgBox("Staff not found")
                    Exit Sub
                End If
            ElseIf txtUserName.Text <> Nothing Then
                If txtUserName.Text = Nothing Then
                    Dim da1 As New SqlDataAdapter("Select * from tblstaff where lower(username)='" & txtUserName.Text.ToLower & "'", con)
                    Dim tbl1 As New DataTable
                    da1.Fill(tbl1)
                    DataGridViewX1.Rows.Clear()
                    For Each r1 As DataRow In tbl1.Rows
                        DataGridViewX1.Rows.Add(r1(0), r1(1), r1(2), r1(3), r1(4), r1(5), r1(6))
                    Next
                    Exit Sub
                Else
                    MsgBox("Staff not found")
                    Exit Sub
                End If

            Else
                MsgBox("Staff not found")
                Exit Sub
            End If

            

        Else
            MsgBox("Search fail please input Staff Name or User Name")
            Exit Sub
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        StaffInfoForm_Load(Nothing, Nothing)
    End Sub

   
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            If DataGridViewX1.SelectedRows.Count = 0 Then
                MsgBox("Please Select Any row to Edit")
                Exit Sub
            End If
            If comformation("Agree to Edit?") = 1 Then
                Exit Sub
            End If
            'Disable Everything
            BFEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)
            btnSearch.Enabled = False
            btnShow.Enabled = False
            'get row index
            Dim index As Integer = DataGridViewX1.CurrentRow.Index
            'get value to text box and combo box

            txtStaffName.Tag = DataGridViewX1.SelectedRows(0).Cells(0).Value

            Dim da As New SqlDataAdapter("select * from tblstaff where staffid='" & txtStaffName.Tag & "'", con)
            Dim tbl As New DataTable
            da.Fill(tbl)
            For Each ra As DataRow In tbl.Rows
                txtStaffName.Text = ra(1)
                txtSalary.Value = ra(3)
                txtUserName.Text = ra(5)
                txtPassword.Text = ra(6)

            Next
            DataGridViewX1.Rows.RemoveAt(index)

        Else
            If check_blank(txtStaffName, "Staff Name") = 1 Then
                Exit Sub
            End If
            If check_blank(txtUserName, "User Name") = 1 Then
                Exit Sub
            End If
            If check_blank(txtPassword, "Password") = 1 Then
                Exit Sub
            End If
            If txtSalary.Value <= 0 Then
                MsgBox("Invalidate Salary")
                txtSalary.Focus()
                Exit Sub
            End If

            Dim cmdTest As New SqlCommand("select * from tblstaff where lower(username)='" & txtUserName.Text.ToLower & "' and staffid !=" & txtStaffName.Tag & "", con)
            If cmdTest.ExecuteScalar >= 1 Then
                MsgBox("Dumplicate Username")
                txtUserName.SelectAll()
                txtUserName.Focus()
                Exit Sub
            End If
         
            BTEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)
            Dim cmd As New SqlCommand("update tblstaff set staffname=N'" & txtStaffName.Text & "',gender='" & cboGender.SelectedItem.ToString & "',salary=" & txtSalary.Value & ",position=" & cboPosition.SelectedValue & ",username='" & txtUserName.Text & "',password='" & txtPassword.Text & "' where staffid='" & txtStaffName.Tag & "'", con)
            cmd.ExecuteNonQuery()
            clears()
            btnSearch.Enabled = True
            btnShow.Enabled = True
            StaffInfoForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clears()
        BTEdit(btnAdd, btnDelete, btnClose, btnEdit, btnCancel)
        btnSearch.Enabled = True
        btnShow.Enabled = True
        btnShow_Click(Nothing, Nothing)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        Else
            EnterAdd(e)
        End If
    End Sub

    Private Sub txtStaffName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffName.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        Else
            EnterSearch(e)
        End If
    End Sub

    Private Sub cboGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboGender.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        End If
    End Sub

    Private Sub cboPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPosition.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        End If
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If btnAdd.Enabled = False Then
            EnterUpdate(e)
        Else
            EnterSearch(e)
        End If
    End Sub

End Class