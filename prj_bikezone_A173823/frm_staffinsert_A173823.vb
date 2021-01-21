Public Class frm_staffinsert_A173823
    Private Sub frm_staffinsert_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_id.Text = generate_id()
    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173823 ORDER BY FLD_STAFF_ID ASC")
        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Phone No"
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A173823").Rows(0).Item("LASTID")
        Dim newid As String = "S" & Mid(lastid, 2) + 1
        Return newid
    End Function

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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) Or String.IsNullOrWhiteSpace(txt_no.Text) Then
            MessageBox.Show("Textbox cannot be empty", "Error")

        Else
            run_sql_command("INSERT INTO TBL_STAFF_A173823 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "'," & txt_no.Text & ")")

            refresh_grid()
            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_no.Text = ""
        End If
    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class