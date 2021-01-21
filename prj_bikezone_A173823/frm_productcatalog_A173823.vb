Public Class frm_productcatalog_A173823
    Private Sub frm_productinfo_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_productid.DataSource = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A173823 ORDER BY FLD_PRODUCT_ID ASC")
        lst_productid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_productid.Text)
    End Sub

    Private Sub refresh_text(product_id As String)
        Dim mysql = run_sql_query("SELECT * FROM TBL_PRODUCT_A173823 WHERE FLD_PRODUCT_ID='" & product_id & "'")

        txt_name.Text = mysql.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = "RM " & mysql.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mysql.Rows(0).Item("FLD_BRAND")
        txt_size.Text = mysql.Rows(0).Item("FLD_SIZE")
        txt_colour.Text = mysql.Rows(0).Item("FLD_COLOUR")
        txt_warranty.Text = mysql.Rows(0).Item("FLD_WARRANTY")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & product_id & ".png")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try
    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productid.MouseClick
        refresh_text(lst_productid.Text)
    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class