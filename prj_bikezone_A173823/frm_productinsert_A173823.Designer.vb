<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productinsert_A173823
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_size = New System.Windows.Forms.ComboBox()
        Me.cmb_warranty = New System.Windows.Forms.ComboBox()
        Me.cmb_colour = New System.Windows.Forms.ComboBox()
        Me.num_price = New System.Windows.Forms.NumericUpDown()
        Me.cmb_brand = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_price, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_title.Location = New System.Drawing.Point(469, 18)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(348, 37)
        Me.lbl_title.TabIndex = 16
        Me.lbl_title.Text = "Add New Product"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grd_product.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.GridColor = System.Drawing.Color.DarkRed
        Me.grd_product.Location = New System.Drawing.Point(12, 101)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(740, 716)
        Me.grd_product.TabIndex = 17
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Gray
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(794, 101)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(212, 200)
        Me.pic_product.TabIndex = 18
        Me.pic_product.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(977, 647)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Warranty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1131, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Colour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(861, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1139, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(853, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(953, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Product Name"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Crimson
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(794, 398)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(477, 30)
        Me.txt_name.TabIndex = 19
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1109, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Product ID"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.Crimson
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.White
        Me.txt_id.Location = New System.Drawing.Point(1085, 160)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(178, 30)
        Me.txt_id.TabIndex = 32
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.Crimson
        Me.btn_picture.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.Color.White
        Me.btn_picture.Location = New System.Drawing.Point(1085, 237)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(178, 64)
        Me.btn_picture.TabIndex = 33
        Me.btn_picture.Text = "Choose Image (png)"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Crimson
        Me.btn_add.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(972, 765)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(127, 52)
        Me.btn_add.TabIndex = 34
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cmb_size
        '
        Me.cmb_size.BackColor = System.Drawing.Color.Crimson
        Me.cmb_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_size.ForeColor = System.Drawing.Color.White
        Me.cmb_size.FormattingEnabled = True
        Me.cmb_size.Items.AddRange(New Object() {"M", "L", "XL"})
        Me.cmb_size.Location = New System.Drawing.Point(794, 593)
        Me.cmb_size.Name = "cmb_size"
        Me.cmb_size.Size = New System.Drawing.Size(186, 33)
        Me.cmb_size.TabIndex = 35
        '
        'cmb_warranty
        '
        Me.cmb_warranty.BackColor = System.Drawing.Color.Crimson
        Me.cmb_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warranty.ForeColor = System.Drawing.Color.White
        Me.cmb_warranty.FormattingEnabled = True
        Me.cmb_warranty.Items.AddRange(New Object() {"1 YEAR", "2 YEAR", "3 YEAR", "LIFETIME"})
        Me.cmb_warranty.Location = New System.Drawing.Point(942, 691)
        Me.cmb_warranty.Name = "cmb_warranty"
        Me.cmb_warranty.Size = New System.Drawing.Size(186, 33)
        Me.cmb_warranty.TabIndex = 36
        '
        'cmb_colour
        '
        Me.cmb_colour.BackColor = System.Drawing.Color.Crimson
        Me.cmb_colour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_colour.ForeColor = System.Drawing.Color.White
        Me.cmb_colour.FormattingEnabled = True
        Me.cmb_colour.Items.AddRange(New Object() {"WHITE", "BLACK", "GREY", "GOLD", "RED", "BLUE", "YELLOW", "ORANGE", "GREEN"})
        Me.cmb_colour.Location = New System.Drawing.Point(1085, 593)
        Me.cmb_colour.Name = "cmb_colour"
        Me.cmb_colour.Size = New System.Drawing.Size(186, 33)
        Me.cmb_colour.TabIndex = 37
        '
        'num_price
        '
        Me.num_price.BackColor = System.Drawing.Color.Crimson
        Me.num_price.DecimalPlaces = 2
        Me.num_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_price.ForeColor = System.Drawing.Color.White
        Me.num_price.Location = New System.Drawing.Point(794, 503)
        Me.num_price.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.num_price.Name = "num_price"
        Me.num_price.Size = New System.Drawing.Size(186, 30)
        Me.num_price.TabIndex = 38
        '
        'cmb_brand
        '
        Me.cmb_brand.BackColor = System.Drawing.Color.Crimson
        Me.cmb_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_brand.ForeColor = System.Drawing.Color.White
        Me.cmb_brand.FormattingEnabled = True
        Me.cmb_brand.Items.AddRange(New Object() {"SHOEI", "ARAI", "AGV", "SCORPION"})
        Me.cmb_brand.Location = New System.Drawing.Point(1085, 503)
        Me.cmb_brand.Name = "cmb_brand"
        Me.cmb_brand.Size = New System.Drawing.Size(186, 33)
        Me.cmb_brand.TabIndex = 39
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_productinsert_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1296, 827)
        Me.Controls.Add(Me.cmb_brand)
        Me.Controls.Add(Me.num_price)
        Me.Controls.Add(Me.cmb_colour)
        Me.Controls.Add(Me.cmb_warranty)
        Me.Controls.Add(Me.cmb_size)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_productinsert_A173823"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_price, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents cmb_size As ComboBox
    Friend WithEvents cmb_warranty As ComboBox
    Friend WithEvents cmb_colour As ComboBox
    Friend WithEvents num_price As NumericUpDown
    Friend WithEvents cmb_brand As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
