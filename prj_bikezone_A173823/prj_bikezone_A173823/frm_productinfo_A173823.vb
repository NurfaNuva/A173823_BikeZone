Public Class frm_productinfo_A173823
    Private Sub frm_productinfo_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_productlist.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A173823 ORDER BY FLD_PRODUCT_ID ASC")
        grd_productlist.Columns(0).HeaderText = "Product ID"
        grd_productlist.Columns(1).HeaderText = "Product Name"
        grd_productlist.Columns(2).HeaderText = "Price"
        grd_productlist.Columns(3).HeaderText = "Brand"
        grd_productlist.Columns(4).HeaderText = "Size"
        grd_productlist.Columns(5).HeaderText = "Colour"
        grd_productlist.Columns(6).HeaderText = "Warranty"

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class