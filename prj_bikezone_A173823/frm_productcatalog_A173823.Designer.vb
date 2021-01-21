<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productcatalog_A173823
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_productid = New System.Windows.Forms.ListBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_title.Location = New System.Drawing.Point(407, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(418, 44)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Product Catalog"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(975, 101)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(221, 253)
        Me.pic_product.TabIndex = 2
        Me.pic_product.TabStop = False
        '
        'lst_productid
        '
        Me.lst_productid.BackColor = System.Drawing.Color.Crimson
        Me.lst_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_productid.ForeColor = System.Drawing.Color.White
        Me.lst_productid.FormattingEnabled = True
        Me.lst_productid.ItemHeight = 25
        Me.lst_productid.Location = New System.Drawing.Point(46, 101)
        Me.lst_productid.Name = "lst_productid"
        Me.lst_productid.Size = New System.Drawing.Size(234, 654)
        Me.lst_productid.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Crimson
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(349, 181)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(576, 30)
        Me.txt_name.TabIndex = 5
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(540, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product Name"
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.Crimson
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.White
        Me.txt_price.Location = New System.Drawing.Point(349, 324)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(234, 30)
        Me.txt_price.TabIndex = 10
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(430, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(767, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 26)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(439, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(758, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Colour"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(569, 566)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Warranty"
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.Color.Crimson
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.ForeColor = System.Drawing.Color.White
        Me.txt_brand.Location = New System.Drawing.Point(691, 324)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(234, 30)
        Me.txt_brand.TabIndex = 15
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_size
        '
        Me.txt_size.BackColor = System.Drawing.Color.Crimson
        Me.txt_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_size.ForeColor = System.Drawing.Color.White
        Me.txt_size.Location = New System.Drawing.Point(349, 473)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.ReadOnly = True
        Me.txt_size.Size = New System.Drawing.Size(234, 30)
        Me.txt_size.TabIndex = 16
        Me.txt_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_colour
        '
        Me.txt_colour.BackColor = System.Drawing.Color.Crimson
        Me.txt_colour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colour.ForeColor = System.Drawing.Color.White
        Me.txt_colour.Location = New System.Drawing.Point(691, 473)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.ReadOnly = True
        Me.txt_colour.Size = New System.Drawing.Size(234, 30)
        Me.txt_colour.TabIndex = 17
        Me.txt_colour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_warranty
        '
        Me.txt_warranty.BackColor = System.Drawing.Color.Crimson
        Me.txt_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warranty.ForeColor = System.Drawing.Color.White
        Me.txt_warranty.Location = New System.Drawing.Point(522, 639)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.ReadOnly = True
        Me.txt_warranty.Size = New System.Drawing.Size(234, 30)
        Me.txt_warranty.TabIndex = 18
        Me.txt_warranty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_productcatalog_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1233, 775)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_colour)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_productid)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_productcatalog_A173823"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Catalog"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_productid As ListBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_size As TextBox
    Friend WithEvents txt_colour As TextBox
    Friend WithEvents txt_warranty As TextBox
End Class
