Public Class frm_productedit_A173823
    Dim current_id As String

    Private Sub frm_productedit_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub refresh_grid()
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A173823 ORDER BY FLD_PRODUCT_ID ASC")
        grd_product.Columns(0).HeaderText = "Product ID"
        grd_product.Columns(1).HeaderText = "Product Name"
        grd_product.Columns(2).HeaderText = "Price"
        grd_product.Columns(3).HeaderText = "Brand"
        grd_product.Columns(4).HeaderText = "Size"
        grd_product.Columns(5).HeaderText = "Colour"
        grd_product.Columns(6).HeaderText = "Warranty"
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_size.Text = ""
        txt_colour.Text = ""
        txt_warranty.Text = ""
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_product.CurrentRow.Index
        current_id = grd_product(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        txt_size.Text = grd_product(4, current_row).Value
        txt_colour.Text = grd_product(5, current_row).Value
        txt_warranty.Text = grd_product(6, current_row).Value
    End Sub

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) Or String.IsNullOrWhiteSpace(txt_price.Text) Or String.IsNullOrWhiteSpace(txt_brand.Text) _
            Or String.IsNullOrWhiteSpace(txt_size.Text) Or String.IsNullOrWhiteSpace(txt_colour.Text) Or String.IsNullOrWhiteSpace(txt_warranty.Text) Then

            MessageBox.Show("Textbox cannot be empty", "Error")

        Else
            run_sql_command("UPDATE TBL_PRODUCT_A173823 SET FLD_PRODUCT_ID='" & txt_id.Text & "', FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE=" & txt_price.Text &
                            ", FLD_BRAND='" & txt_brand.Text & "', FLD_SIZE='" & txt_size.Text & "', FLD_COLOUR='" & txt_colour.Text & "', FLD_WARRANTY='" & txt_warranty.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated the product """ & current_id & """.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Try
                run_sql_command("DELETE FROM TBL_PRODUCT_A173823 WHERE FLD_PRODUCT_ID='" & current_id & "'")

                System.IO.File.Delete("pictures/" & current_id & ".png")

                Beep()
                MsgBox("The product """ & current_id & """ has been successfully deleted.")

                refresh_grid()
                clear_fields()
                get_current_id()

            Catch ex As Exception
                MsgBox("Image fail to delete")
            End Try
        End If
    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged
        If IsNumeric(txt_price.Text) Or String.IsNullOrEmpty(txt_price.Text) Then
            'do nothing 
        Else
            'display error message
            MessageBox.Show("Numbers only", "Error")
            'clear textbox 
            txt_price.Text = ""
        End If
    End Sub

    Private Sub frm_productedit_A173823_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class