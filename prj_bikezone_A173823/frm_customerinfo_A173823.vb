Public Class frm_customerinfo_A173823
    Private Sub frm_customerinfo_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_custinfo.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A173823 ORDER BY FLD_CUSTOMER_ID ASC")
        grd_custinfo.Columns(0).HeaderText = "Customer ID"
        grd_custinfo.Columns(1).HeaderText = "Customer Name"
        grd_custinfo.Columns(2).HeaderText = "Customer Phone No"

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class