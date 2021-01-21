Public Class frm_makeorder_A173823
    Dim qty As Integer
    Dim price As Double

    Private Sub frm_makeorder_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_orderid()
        txt_staffid.Text = generate_staffid()
        generate_custid()
        generate_custname(cmb_custid.Text)
        AddHandler cmb_custid.SelectedIndexChanged, AddressOf refresh_name
        Dim orderdate As String = DateTime.Now.ToString("dd MMM yyyy, HH:mm:dddd")
        txt_orderdate.Text = orderdate

        lst_productid.DataSource = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A173823 ORDER BY FLD_PRODUCT_ID ASC")
        lst_productid.DisplayMember = "FLD_PRODUCT_ID"
        refresh_product(lst_productid.Text)

        Dim data As DataTable = run_sql_query("SELECT * FROM TBL_PURCHASE_A173823")
        grd_cart.ColumnCount = data.Columns.Count
        For i = 0 To data.Columns.Count - 1
            grd_cart.Columns(i).HeaderText = data.Columns(i).ColumnName
        Next
        grd_cart.Columns(0).HeaderText = "Order ID"
        grd_cart.Columns(1).HeaderText = "Product ID"
        grd_cart.Columns(2).HeaderText = "Quantity"
        grd_cart.Columns(3).HeaderText = "Price"
    End Sub

    Private Sub generate_orderid()
        Dim count As Integer = 1
        Dim lastid = run_sql_query("SELECT COUNT(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A173823")
        count += lastid.Rows(0).Item("LASTID")
        txt_orderid.Text = "T" + count.ToString("00")
    End Sub

    Private Function generate_staffid() As String
        Dim rdm As New Random()
        Dim data As DataTable = run_sql_query("SELECT FLD_STAFF_ID AS RN FROM TBL_STAFF_A173823 ORDER BY RND()")
        Dim rands As String = data.Rows(rdm.Next(0, data.Rows.Count)).Item("RN")
        Return rands
    End Function

    Private Sub generate_custid()
        cmb_custid.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A173823")
        cmb_custid.DisplayMember = "FLD_CUSTOMER_ID"
    End Sub

    Private Sub generate_custname(cust_name As String)
        Dim mysql = run_sql_query("SELECT * FROM TBL_CUSTOMER_A173823 WHERE FLD_CUSTOMER_ID='" & cust_name & "'")
        txt_custname.Text = mysql.Rows(0).Item("FLD_CUSTOMER_NAME")
    End Sub

    Private Sub refresh_name(sender As Object, e As EventArgs)
        generate_custname(cmb_custid.Text)
    End Sub

    'method lain utk customer name
    'Private Sub cmb_custid_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_custid.SelectedValueChanged
    '    Try
    '        refresh_custname(cmb_custid.Text)
    '    Catch ex As Exception
    '        MsgBox(cmb_custid.Text)
    '    End Try
    'End Sub

    Private Sub refresh_product(product_id As String)
        Dim mysql = run_sql_query("SELECT * FROM TBL_PRODUCT_A173823 WHERE FLD_PRODUCT_ID='" & product_id & "'")

        txt_productname.Text = mysql.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_productprice.Text = mysql.Rows(0).Item("FLD_PRICE")
        txt_productbrand.Text = mysql.Rows(0).Item("FLD_BRAND")
        txt_productsize.Text = mysql.Rows(0).Item("FLD_SIZE")
        txt_productcolor.Text = mysql.Rows(0).Item("FLD_COLOUR")
        txt_productwrnty.Text = mysql.Rows(0).Item("FLD_WARRANTY")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & product_id & ".png")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

        num_qty.Value = 1
        lbl_subtotal.Text = num_qty.Text * txt_productprice.Text
    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productid.MouseClick
        refresh_product(lst_productid.Text)
    End Sub

    Private Sub num_qty_ValueChanged(sender As Object, e As EventArgs) Handles num_qty.ValueChanged
        qty = num_qty.Text
        price = txt_productprice.Text()
        lbl_subtotal.Text = qty * price
    End Sub

    Private Sub btn_addcart_Click(sender As Object, e As EventArgs) Handles btn_addcart.Click
        For Each row As DataGridViewRow In grd_cart.Rows
            If (row.Cells(0).Value = txt_orderid.Text And row.Cells(1).Value = lst_productid.Text) Then
                row.Cells(2).Value = Val(row.Cells(2).Value) + num_qty.Text
                row.Cells(3).Value = row.Cells(2).Value * txt_productprice.Text
                lbl_total.Text = Val(lbl_subtotal.Text) + Val(lbl_total.Text)
                Return
            Else

            End If
        Next
        grd_cart.Rows.Add(txt_orderid.Text, lst_productid.Text, num_qty.Text, lbl_subtotal.Text)
        lbl_total.Text = Val(lbl_subtotal.Text) + Val(lbl_total.Text)

        cmb_custid.Enabled = False
    End Sub

    Private Sub btn_removecart_Click(sender As Object, e As EventArgs) Handles btn_removecart.Click
        Try
            Dim n As Integer = grd_cart.SelectedRows(0).Index
            lbl_total.Text = Val(lbl_total.Text) - Val(grd_cart.Rows(n).Cells(3).Value)
            grd_cart.Rows.RemoveAt(n)
        Catch ex As Exception
            MessageBox.Show("There Are No Items in Cart and Please Choose an Item", "Cart")
        End Try
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        If (grd_cart.Rows.Count = 0) Then
            MessageBox.Show("Please Add Item To Cart", "Check Out")
        Else
            Dim transaction As OleDb.OleDbTransaction
            myconnection2.Open()
            transaction = myconnection2.BeginTransaction
            Try
                Dim orderid As String = txt_orderid.Text
                Dim customerid As String = cmb_custid.Text
                Dim staffid As String = txt_staffid.Text
                Dim orderdate As String = DateTime.Now.ToString("dd MMMM yyyy, hh:mm dddd")

                Dim mysql1 As String = "INSERT INTO TBL_ORDER_A173823 VALUES ('" & orderid & "', '" & orderdate & "', '" & customerid & "', '" & staffid & "')"
                Dim mywriter1 As New OleDb.OleDbCommand(mysql1, myconnection2, transaction)
                mywriter1.ExecuteNonQuery()

                For i As Integer = 0 To grd_cart.RowCount - 1
                    Dim orderids As String = grd_cart(0, i).Value
                    Dim productids As String = grd_cart(1, i).Value
                    Dim qtys As String = grd_cart(2, i).Value
                    Dim prices As String = grd_cart(3, i).Value

                    Dim mysql2 As String = "INSERT INTO TBL_PURCHASE_A173823 VALUES ('" & orderids & "', '" & productids & "', '" & qtys & "', '" & prices & "')"
                    Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, transaction)
                    mywriter2.ExecuteNonQuery()
                Next
                transaction.Commit()
                myconnection2.Close()

                Beep()
                MessageBox.Show("Transaction Successful!", "Check Out")
                grd_cart.Rows.Clear()

                refresh_product(lst_productid.Text)
                generate_orderid()

                cmb_custid.Enabled = True

            Catch ex As Exception
                Beep()
                MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
                transaction.Rollback()

                myconnection2.Close()

            End Try
        End If
    End Sub

    Private Sub frm_makeorder_A173823_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class