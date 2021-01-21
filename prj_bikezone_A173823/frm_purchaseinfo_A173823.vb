Public Class frm_purchaseinfo_A173823
    Private Sub frm_purchase_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_purchaseinfo.DataSource = run_sql_query("SELECT * FROM TBL_PURCHASE_A173823")
        grd_purchaseinfo.Columns(0).HeaderText = "Order ID"
        grd_purchaseinfo.Columns(1).HeaderText = "Product ID"
        grd_purchaseinfo.Columns(2).HeaderText = "Quantity"

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class