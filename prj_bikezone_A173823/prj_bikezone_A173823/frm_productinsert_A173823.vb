Public Class frm_productinsert_A173823
    Dim defaultpic As String = Application.StartupPath & "\pictures\nophoto.png"
    Dim filepic As String

    Private Sub frm_productinsert_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_id.Text = generate_id()
        pic_product.BackgroundImage = Image.FromFile(defaultpic)
        filepic = defaultpic

        cmb_brand.SelectedItem = "SHOEI"
        cmb_size.SelectedItem = "M"
        cmb_colour.SelectedItem = "WHITE"
        cmb_warranty.SelectedItem = "1 YEAR"
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

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A173823").Rows(0).Item("LASTID")
        Dim newid As String = "M" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PNG file (*.png)|*.png"
        OpenFileDialog1.ShowDialog()

        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            filepic = OpenFileDialog1.FileName

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile(defaultpic)
            filepic = defaultpic
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) Or String.IsNullOrWhiteSpace(num_price.Text) Or String.IsNullOrWhiteSpace(cmb_brand.Text) _
            Or String.IsNullOrWhiteSpace(cmb_size.Text) Or String.IsNullOrWhiteSpace(cmb_colour.Text) Or String.IsNullOrWhiteSpace(cmb_warranty.Text) Then

            MessageBox.Show("Textbox cannot be empty", "Error")

        Else
            run_sql_command("INSERT INTO TBL_PRODUCT_A173823 VALUES('" & txt_id.Text & "','" & txt_name.Text & "'," & num_price.Value & ",'" &
                        cmb_brand.Text & "','" & cmb_size.Text & "','" & cmb_colour.Text & "','" & cmb_warranty.Text & "')")

            My.Computer.FileSystem.CopyFile(filepic, "pictures\" & txt_id.Text & ".png")

            refresh_grid()
            txt_id.Text = generate_id()
            txt_name.Text = ""
            num_price.Value = 0
            cmb_brand.SelectedItem = "SHOEI"
            cmb_size.SelectedItem = "M"
            cmb_colour.SelectedItem = "WHITE"
            cmb_warranty.SelectedItem = "1 YEAR"

            pic_product.BackgroundImage = Image.FromFile(defaultpic)
            filepic = defaultpic
        End If

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
    '    frm_mainmenu_A173823.Show()
    '    Me.Close()
    'End Sub
End Class