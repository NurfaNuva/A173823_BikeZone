Public Class frm_staffinfo_A173823
    Private Sub frm_staff_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staffinfo.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173823 ORDER BY FLD_STAFF_ID ASC")
        grd_staffinfo.Columns(0).HeaderText = "Staff ID"
        grd_staffinfo.Columns(1).HeaderText = "Staff Name"
        grd_staffinfo.Columns(2).HeaderText = "Staff Phone No"

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class