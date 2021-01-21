Public Class frm_vieworder_A173823
    Dim size As Bitmap

    Private Sub frm_vieworder_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_id()
        refresh_table(cmb_orderid.Text)
        AddHandler cmb_orderid.SelectedIndexChanged, AddressOf refresh_name
    End Sub

    Private Sub refresh_name(sender As Object, e As EventArgs)
        refresh_table(cmb_orderid.Text)
    End Sub

    Private Sub generate_id()
        cmb_orderid.DataSource = run_sql_query("SELECT FLD_ORDER_ID FROM TBL_ORDER_A173823")
        cmb_orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub refresh_table(id As String)
        lbl_productid.Text = ""
        lbl_productname.Text = ""
        lbl_unit.Text = ""
        lbl_qty.Text = ""
        lbl_subtotal.Text = ""
        lbl_total.Text = ""
        Dim mysql = run_sql_query("SELECT * FROM TBL_ORDER_A173823 WHERE FLD_ORDER_ID='" & id & "'")
        lbl_orderid.Text = mysql.Rows(0).Item("FLD_ORDER_ID")
        lbl_date.Text = mysql.Rows(0).Item("FLD_ORDER_DATE")

        Dim data = run_sql_query("SELECT * FROM TBL_PURCHASE_A173823 WHERE FLD_ORDER_ID='" & id & "'")
        For Each row As DataRow In data.Rows
            Dim item = run_sql_query("SELECT FLD_PRODUCT_NAME, FLD_PRICE FROM TBL_PRODUCT_A173823 WHERE FLD_PRODUCT_ID = '" & row.Item("FLD_PRODUCT_ID") & "'")

            lbl_productid.Text += row.Item("FLD_PRODUCT_ID") + Environment.NewLine
            lbl_productname.Text += item.Rows(0).Item("FLD_PRODUCT_NAME") + Environment.NewLine
            lbl_unit.Text += "RM" + item.Rows(0).Item("FLD_PRICE").ToString + Environment.NewLine
            lbl_qty.Text += row.Item("FLD_QUANTITY").ToString + Environment.NewLine
            lbl_subtotal.Text += "RM" + row.Item("FLD_PRICE").ToString + Environment.NewLine
            lbl_total.Text = Val(lbl_total.Text) + row.Item("FLD_PRICE")
        Next

        lbl_productid.Text = lbl_productid.Text.Remove(lbl_productid.Text.LastIndexOf(Environment.NewLine))
        lbl_productname.Text = lbl_productname.Text.Remove(lbl_productname.Text.LastIndexOf(Environment.NewLine))
        lbl_unit.Text = lbl_unit.Text.Remove(lbl_unit.Text.LastIndexOf(Environment.NewLine))
        lbl_qty.Text = lbl_qty.Text.Remove(lbl_qty.Text.LastIndexOf(Environment.NewLine))
        lbl_subtotal.Text = lbl_subtotal.Text.Remove(lbl_subtotal.Text.LastIndexOf(Environment.NewLine))
        lbl_total.Text = "RM" + lbl_total.Text
    End Sub

    Private Sub frm_vieworder_A173823_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class