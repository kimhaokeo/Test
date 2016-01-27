Public Class MainForm

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        openfrm(PositionForm)
        PositionForm.PositionForm_Load(Nothing, Nothing)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub btnStaffInfo_Click(sender As Object, e As EventArgs) Handles btnStaffInfo.Click
        openfrm(StaffInfoForm)
    End Sub
End Class
