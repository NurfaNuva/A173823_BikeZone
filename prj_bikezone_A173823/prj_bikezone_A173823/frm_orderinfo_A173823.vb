Public Class frm_orderinfo_A173823
    Private Sub frm_order_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_orderinfo.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_A173823 ORDER BY FLD_ORDER_ID ASC")
        grd_orderinfo.Columns(0).HeaderText = "Order ID"
        grd_orderinfo.Columns(1).HeaderText = "Order Date"
        grd_orderinfo.Columns(2).HeaderText = "Customer ID"
        grd_orderinfo.Columns(3).HeaderText = "Staff ID"

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class