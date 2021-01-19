Public Class frm_staffedit_A173823
    Dim current_id As String

    Private Sub frm_staffedit_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173823 ORDER BY FLD_STAFF_ID ASC")
        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Phone No"
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_no.Text = ""
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_no.Text = grd_staff(2, current_row).Value
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) Or String.IsNullOrWhiteSpace(txt_no.Text) Then
            MessageBox.Show("Textbox cannot be empty", "Error")

        Else
            run_sql_command("UPDATE TBL_STAFF_A173823 SET FLD_STAFF_ID='" & txt_id.Text & "', FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_NO=" & txt_no.Text & " WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated the staff """ & current_id & """.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are sure you would like to delete the staff """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A173823 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The staff """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub

    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If IsNumeric(txt_no.Text) Or String.IsNullOrEmpty(txt_no.Text) Then
            'do nothing 
        Else
            'display error message
            MessageBox.Show("Numbers only and Enter suitable Phone Number eg(0123456789)", "Error")
            'clear textbox 
            txt_no.Text = ""
        End If
    End Sub

    Private Sub frm_staffedit_A173823_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class