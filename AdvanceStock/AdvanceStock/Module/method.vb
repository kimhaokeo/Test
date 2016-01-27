Imports System.Data.SqlClient
Module method
    Function check_blank(ByVal txt As TextBox, ByVal str As String)
        Dim i As Integer = 0
        If txt.Text = Nothing Then
            MsgBox("Please Input " & str & "")
            txt.SelectAll()
            txt.Focus()
            i = 1
        End If
        Return i
    End Function

    Sub check_connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    
    Sub DeleteDB(ByVal dgv As DataGridView, ByVal tbl As String, ByVal column As String)
        For Each rows As DataGridViewRow In dgv.SelectedRows
            If comformation("Accept Delete") = 1 Then
                Exit Sub
            End If
            Dim id As Integer = dgv.SelectedRows(0).Cells(0).Value
            Dim cmd As New SqlCommand("delete from " & tbl & " where " & column & "=" & id & "", con)
            cmd.ExecuteNonQuery()
            dgv.Rows.Remove(rows)
        Next
    End Sub

    Function comformation(ByVal txt As String)
        Dim i As Integer = 0
        Dim r As Integer = MessageBox.Show("" & txt & "", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = DialogResult.No Then
            i = 1
        End If
        Return i
    End Function

    Sub openfrm(ByVal frm2 As Form)
        Background.Show()
        Background.MdiParent = MainForm
        Background.Dock = DockStyle.Fill
        Background.Activate()
        frm2.Show()
        frm2.Size = Background.PanelEx1.Size
        frm2.Location = Background.PanelEx1.Location
        frm2.Activate()
    End Sub
    Sub BFEdit(ByVal btn As DevComponents.DotNetBar.ButtonX, ByVal btn1 As DevComponents.DotNetBar.ButtonX, ByVal btn2 As DevComponents.DotNetBar.ButtonX, ByVal btn3 As DevComponents.DotNetBar.ButtonX, ByVal btn4 As DevComponents.DotNetBar.ButtonX)
        btn.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        MainForm.btnStaffControl.Enabled = False
        MainForm.btnProductControl.Enabled = False
        MainForm.btnClose.Enabled = False
        btn3.Text = "Update"
        btn4.Visible = True
    End Sub
    Sub BTEdit(ByVal btn As DevComponents.DotNetBar.ButtonX, ByVal btn1 As DevComponents.DotNetBar.ButtonX, ByVal btn2 As DevComponents.DotNetBar.ButtonX, ByVal btn3 As DevComponents.DotNetBar.ButtonX, ByVal btn4 As DevComponents.DotNetBar.ButtonX)
        btn.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Text = "Edit"
        btn4.Visible = False
        MainForm.btnStaffControl.Enabled = True
        MainForm.btnProductControl.Enabled = True
        MainForm.btnClose.Enabled = True
    End Sub
End Module
