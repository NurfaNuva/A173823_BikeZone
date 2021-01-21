<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_A173823
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.cmb_custid = New System.Windows.Forms.ComboBox()
        Me.lst_productid = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.txt_productprice = New System.Windows.Forms.TextBox()
        Me.txt_productbrand = New System.Windows.Forms.TextBox()
        Me.txt_productsize = New System.Windows.Forms.TextBox()
        Me.txt_productcolor = New System.Windows.Forms.TextBox()
        Me.txt_productwrnty = New System.Windows.Forms.TextBox()
        Me.num_qty = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.btn_addcart = New System.Windows.Forms.Button()
        Me.btn_removecart = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grd_cart = New System.Windows.Forms.DataGridView()
        Me.txt_orderdate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_title.Location = New System.Drawing.Point(550, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(242, 37)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Make Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Order ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(401, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Staff ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Customer ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(401, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Customer Name"
        '
        'txt_orderid
        '
        Me.txt_orderid.BackColor = System.Drawing.Color.Crimson
        Me.txt_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderid.ForeColor = System.Drawing.Color.White
        Me.txt_orderid.Location = New System.Drawing.Point(193, 88)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(157, 30)
        Me.txt_orderid.TabIndex = 13
        Me.txt_orderid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_staffid
        '
        Me.txt_staffid.BackColor = System.Drawing.Color.Crimson
        Me.txt_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.ForeColor = System.Drawing.Color.White
        Me.txt_staffid.Location = New System.Drawing.Point(629, 88)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(157, 30)
        Me.txt_staffid.TabIndex = 15
        Me.txt_staffid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_custname
        '
        Me.txt_custname.BackColor = System.Drawing.Color.Crimson
        Me.txt_custname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custname.ForeColor = System.Drawing.Color.White
        Me.txt_custname.Location = New System.Drawing.Point(629, 138)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.ReadOnly = True
        Me.txt_custname.Size = New System.Drawing.Size(157, 30)
        Me.txt_custname.TabIndex = 16
        Me.txt_custname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_custid
        '
        Me.cmb_custid.BackColor = System.Drawing.Color.Crimson
        Me.cmb_custid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_custid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_custid.ForeColor = System.Drawing.Color.White
        Me.cmb_custid.FormattingEnabled = True
        Me.cmb_custid.Location = New System.Drawing.Point(193, 137)
        Me.cmb_custid.Name = "cmb_custid"
        Me.cmb_custid.Size = New System.Drawing.Size(157, 33)
        Me.cmb_custid.TabIndex = 40
        '
        'lst_productid
        '
        Me.lst_productid.BackColor = System.Drawing.Color.Crimson
        Me.lst_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_productid.ForeColor = System.Drawing.Color.White
        Me.lst_productid.FormattingEnabled = True
        Me.lst_productid.ItemHeight = 25
        Me.lst_productid.Location = New System.Drawing.Point(13, 51)
        Me.lst_productid.Name = "lst_productid"
        Me.lst_productid.Size = New System.Drawing.Size(126, 479)
        Me.lst_productid.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(177, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Warranty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(177, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Colour"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(177, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 21)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(177, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Brand"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(177, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(485, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 21)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Product Name"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Gray
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(181, 51)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(134, 136)
        Me.pic_product.TabIndex = 48
        Me.pic_product.TabStop = False
        '
        'txt_productname
        '
        Me.txt_productname.BackColor = System.Drawing.Color.Crimson
        Me.txt_productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.ForeColor = System.Drawing.Color.White
        Me.txt_productname.Location = New System.Drawing.Point(355, 97)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.ReadOnly = True
        Me.txt_productname.Size = New System.Drawing.Size(419, 30)
        Me.txt_productname.TabIndex = 50
        Me.txt_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productprice
        '
        Me.txt_productprice.BackColor = System.Drawing.Color.Crimson
        Me.txt_productprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productprice.ForeColor = System.Drawing.Color.White
        Me.txt_productprice.Location = New System.Drawing.Point(318, 219)
        Me.txt_productprice.Name = "txt_productprice"
        Me.txt_productprice.ReadOnly = True
        Me.txt_productprice.Size = New System.Drawing.Size(157, 30)
        Me.txt_productprice.TabIndex = 51
        Me.txt_productprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productbrand
        '
        Me.txt_productbrand.BackColor = System.Drawing.Color.Crimson
        Me.txt_productbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productbrand.ForeColor = System.Drawing.Color.White
        Me.txt_productbrand.Location = New System.Drawing.Point(318, 277)
        Me.txt_productbrand.Name = "txt_productbrand"
        Me.txt_productbrand.ReadOnly = True
        Me.txt_productbrand.Size = New System.Drawing.Size(157, 30)
        Me.txt_productbrand.TabIndex = 52
        Me.txt_productbrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productsize
        '
        Me.txt_productsize.BackColor = System.Drawing.Color.Crimson
        Me.txt_productsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productsize.ForeColor = System.Drawing.Color.White
        Me.txt_productsize.Location = New System.Drawing.Point(318, 335)
        Me.txt_productsize.Name = "txt_productsize"
        Me.txt_productsize.ReadOnly = True
        Me.txt_productsize.Size = New System.Drawing.Size(157, 30)
        Me.txt_productsize.TabIndex = 53
        Me.txt_productsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productcolor
        '
        Me.txt_productcolor.BackColor = System.Drawing.Color.Crimson
        Me.txt_productcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productcolor.ForeColor = System.Drawing.Color.White
        Me.txt_productcolor.Location = New System.Drawing.Point(318, 393)
        Me.txt_productcolor.Name = "txt_productcolor"
        Me.txt_productcolor.ReadOnly = True
        Me.txt_productcolor.Size = New System.Drawing.Size(157, 30)
        Me.txt_productcolor.TabIndex = 54
        Me.txt_productcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productwrnty
        '
        Me.txt_productwrnty.BackColor = System.Drawing.Color.Crimson
        Me.txt_productwrnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productwrnty.ForeColor = System.Drawing.Color.White
        Me.txt_productwrnty.Location = New System.Drawing.Point(318, 451)
        Me.txt_productwrnty.Name = "txt_productwrnty"
        Me.txt_productwrnty.ReadOnly = True
        Me.txt_productwrnty.Size = New System.Drawing.Size(157, 30)
        Me.txt_productwrnty.TabIndex = 55
        Me.txt_productwrnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_qty
        '
        Me.num_qty.BackColor = System.Drawing.Color.Crimson
        Me.num_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_qty.ForeColor = System.Drawing.Color.White
        Me.num_qty.Location = New System.Drawing.Point(545, 277)
        Me.num_qty.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_qty.Name = "num_qty"
        Me.num_qty.ReadOnly = True
        Me.num_qty.Size = New System.Drawing.Size(229, 30)
        Me.num_qty.TabIndex = 56
        Me.num_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(609, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 21)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(541, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 21)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Sub-Total"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.White
        Me.lbl_subtotal.Location = New System.Drawing.Point(636, 420)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(34, 31)
        Me.lbl_subtotal.TabIndex = 59
        Me.lbl_subtotal.Text = "0"
        '
        'btn_addcart
        '
        Me.btn_addcart.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_addcart.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addcart.ForeColor = System.Drawing.Color.White
        Me.btn_addcart.Location = New System.Drawing.Point(600, 483)
        Me.btn_addcart.Name = "btn_addcart"
        Me.btn_addcart.Size = New System.Drawing.Size(203, 48)
        Me.btn_addcart.TabIndex = 60
        Me.btn_addcart.Text = "Add To Cart"
        Me.btn_addcart.UseVisualStyleBackColor = False
        '
        'btn_removecart
        '
        Me.btn_removecart.BackColor = System.Drawing.Color.Red
        Me.btn_removecart.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removecart.ForeColor = System.Drawing.Color.White
        Me.btn_removecart.Location = New System.Drawing.Point(535, 301)
        Me.btn_removecart.Name = "btn_removecart"
        Me.btn_removecart.Size = New System.Drawing.Size(203, 48)
        Me.btn_removecart.TabIndex = 63
        Me.btn_removecart.Text = "Remove Item"
        Me.btn_removecart.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Copperplate Gothic Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(308, 420)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(46, 43)
        Me.lbl_total.TabIndex = 65
        Me.lbl_total.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(89, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 26)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Total"
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_confirm.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.White
        Me.btn_confirm.Location = New System.Drawing.Point(535, 482)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(203, 48)
        Me.btn_confirm.TabIndex = 66
        Me.btn_confirm.Text = "Check Out"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lst_productid)
        Me.GroupBox1.Controls.Add(Me.pic_product)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_addcart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_productwrnty)
        Me.GroupBox1.Controls.Add(Me.num_qty)
        Me.GroupBox1.Controls.Add(Me.txt_productcolor)
        Me.GroupBox1.Controls.Add(Me.txt_productname)
        Me.GroupBox1.Controls.Add(Me.txt_productprice)
        Me.GroupBox1.Controls.Add(Me.txt_productbrand)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_productsize)
        Me.GroupBox1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 537)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(566, 420)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 31)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "RM"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.grd_cart)
        Me.GroupBox2.Controls.Add(Me.btn_removecart)
        Me.GroupBox2.Controls.Add(Me.btn_confirm)
        Me.GroupBox2.Controls.Add(Me.lbl_total)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(844, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 537)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cart"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Copperplate Gothic Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(191, 420)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 43)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "RM"
        '
        'grd_cart
        '
        Me.grd_cart.AllowUserToAddRows = False
        Me.grd_cart.AllowUserToDeleteRows = False
        Me.grd_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_cart.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_cart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_cart.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_cart.GridColor = System.Drawing.Color.DarkRed
        Me.grd_cart.Location = New System.Drawing.Point(6, 51)
        Me.grd_cart.Name = "grd_cart"
        Me.grd_cart.ReadOnly = True
        Me.grd_cart.RowHeadersWidth = 51
        Me.grd_cart.RowTemplate.Height = 24
        Me.grd_cart.Size = New System.Drawing.Size(732, 244)
        Me.grd_cart.TabIndex = 67
        '
        'txt_orderdate
        '
        Me.txt_orderdate.BackColor = System.Drawing.Color.Crimson
        Me.txt_orderdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderdate.ForeColor = System.Drawing.Color.White
        Me.txt_orderdate.Location = New System.Drawing.Point(1068, 88)
        Me.txt_orderdate.Name = "txt_orderdate"
        Me.txt_orderdate.ReadOnly = True
        Me.txt_orderdate.Size = New System.Drawing.Size(352, 30)
        Me.txt_orderdate.TabIndex = 70
        Me.txt_orderdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(840, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 21)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Order Date"
        '
        'frm_makeorder_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1600, 761)
        Me.Controls.Add(Me.txt_orderdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_custid)
        Me.Controls.Add(Me.txt_custname)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_makeorder_A173823"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Order"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents cmb_custid As ComboBox
    Friend WithEvents lst_productid As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents txt_productprice As TextBox
    Friend WithEvents txt_productbrand As TextBox
    Friend WithEvents txt_productsize As TextBox
    Friend WithEvents txt_productcolor As TextBox
    Friend WithEvents txt_productwrnty As TextBox
    Friend WithEvents num_qty As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents btn_addcart As Button
    Friend WithEvents btn_removecart As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_orderdate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents grd_cart As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
