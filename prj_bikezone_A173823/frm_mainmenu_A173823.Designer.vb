<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainmenu_A173823
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_A173823))
        Me.Menustrip = New System.Windows.Forms.MenuStrip()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductCatalog = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Menustrip.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menustrip
        '
        Me.Menustrip.BackColor = System.Drawing.Color.Transparent
        Me.Menustrip.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menustrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem, Me.OrderToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.InsertToolStripMenuItem, Me.CatalogToolStripMenuItem, Me.InformationToolStripMenuItem1})
        Me.Menustrip.Location = New System.Drawing.Point(0, 0)
        Me.Menustrip.Name = "Menustrip"
        Me.Menustrip.Size = New System.Drawing.Size(1365, 57)
        Me.Menustrip.TabIndex = 7
        Me.Menustrip.Text = "MenuStrip1"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InformationToolStripMenuItem.BackgroundImage = Global.prj_bikezone_A173823.My.Resources.Resources.BIKEZONE1
        Me.InformationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InformationToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(344, 53)
        Me.InformationToolStripMenuItem.Text = "                            "
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OrderToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeOrderToolStripMenuItem, Me.ViewOrderToolStripMenuItem})
        Me.OrderToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(183, 53)
        Me.OrderToolStripMenuItem.Text = "purchase"
        '
        'MakeOrderToolStripMenuItem
        '
        Me.MakeOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MakeOrderToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MakeOrderToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MakeOrderToolStripMenuItem.Name = "MakeOrderToolStripMenuItem"
        Me.MakeOrderToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.MakeOrderToolStripMenuItem.Text = "make order"
        '
        'ViewOrderToolStripMenuItem
        '
        Me.ViewOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ViewOrderToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewOrderToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ViewOrderToolStripMenuItem.Name = "ViewOrderToolStripMenuItem"
        Me.ViewOrderToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.ViewOrderToolStripMenuItem.Text = "view order"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductUpdate, Me.StaffUpdate, Me.CustomerUpdate})
        Me.UpdateToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(142, 53)
        Me.UpdateToolStripMenuItem.Text = "update"
        '
        'ProductUpdate
        '
        Me.ProductUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProductUpdate.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProductUpdate.Name = "ProductUpdate"
        Me.ProductUpdate.Size = New System.Drawing.Size(228, 30)
        Me.ProductUpdate.Text = "product"
        '
        'StaffUpdate
        '
        Me.StaffUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StaffUpdate.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StaffUpdate.Name = "StaffUpdate"
        Me.StaffUpdate.Size = New System.Drawing.Size(228, 30)
        Me.StaffUpdate.Text = "staff"
        '
        'CustomerUpdate
        '
        Me.CustomerUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CustomerUpdate.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerUpdate.Name = "CustomerUpdate"
        Me.CustomerUpdate.Size = New System.Drawing.Size(228, 30)
        Me.CustomerUpdate.Text = "customer"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductInsert, Me.StaffInsert, Me.CustomerInsert})
        Me.InsertToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(131, 53)
        Me.InsertToolStripMenuItem.Text = "insert"
        '
        'ProductInsert
        '
        Me.ProductInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProductInsert.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductInsert.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProductInsert.Name = "ProductInsert"
        Me.ProductInsert.Size = New System.Drawing.Size(228, 30)
        Me.ProductInsert.Text = "product"
        '
        'StaffInsert
        '
        Me.StaffInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StaffInsert.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInsert.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StaffInsert.Name = "StaffInsert"
        Me.StaffInsert.Size = New System.Drawing.Size(228, 30)
        Me.StaffInsert.Text = "staff"
        '
        'CustomerInsert
        '
        Me.CustomerInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CustomerInsert.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInsert.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerInsert.Name = "CustomerInsert"
        Me.CustomerInsert.Size = New System.Drawing.Size(228, 30)
        Me.CustomerInsert.Text = "customer"
        '
        'CatalogToolStripMenuItem
        '
        Me.CatalogToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CatalogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductCatalog})
        Me.CatalogToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatalogToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.CatalogToolStripMenuItem.Name = "CatalogToolStripMenuItem"
        Me.CatalogToolStripMenuItem.Size = New System.Drawing.Size(166, 53)
        Me.CatalogToolStripMenuItem.Text = "catalog"
        '
        'ProductCatalog
        '
        Me.ProductCatalog.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProductCatalog.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCatalog.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProductCatalog.Name = "ProductCatalog"
        Me.ProductCatalog.Size = New System.Drawing.Size(224, 30)
        Me.ProductCatalog.Text = "product"
        '
        'InformationToolStripMenuItem1
        '
        Me.InformationToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.InformationToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.InformationToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductInfo, Me.StaffInfo, Me.CustomerInfo, Me.OrderInfo, Me.PurchaseInfo})
        Me.InformationToolStripMenuItem1.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray
        Me.InformationToolStripMenuItem1.Name = "InformationToolStripMenuItem1"
        Me.InformationToolStripMenuItem1.Size = New System.Drawing.Size(229, 53)
        Me.InformationToolStripMenuItem1.Text = "information"
        '
        'ProductInfo
        '
        Me.ProductInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProductInfo.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProductInfo.Name = "ProductInfo"
        Me.ProductInfo.Size = New System.Drawing.Size(228, 30)
        Me.ProductInfo.Text = "product"
        '
        'StaffInfo
        '
        Me.StaffInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StaffInfo.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StaffInfo.Name = "StaffInfo"
        Me.StaffInfo.Size = New System.Drawing.Size(228, 30)
        Me.StaffInfo.Text = "staff"
        '
        'CustomerInfo
        '
        Me.CustomerInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CustomerInfo.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerInfo.Name = "CustomerInfo"
        Me.CustomerInfo.Size = New System.Drawing.Size(228, 30)
        Me.CustomerInfo.Text = "customer"
        '
        'OrderInfo
        '
        Me.OrderInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OrderInfo.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OrderInfo.Name = "OrderInfo"
        Me.OrderInfo.Size = New System.Drawing.Size(228, 30)
        Me.OrderInfo.Text = "order"
        '
        'PurchaseInfo
        '
        Me.PurchaseInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PurchaseInfo.Font = New System.Drawing.Font("Copperplate Gothic Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PurchaseInfo.Name = "PurchaseInfo"
        Me.PurchaseInfo.Size = New System.Drawing.Size(228, 30)
        Me.PurchaseInfo.Text = "purchase"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1015, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(338, 598)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(390, 429)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(619, 343)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(474, 152)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(451, 271)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 598)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frm_mainmenu_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 784)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Menustrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.Menustrip
        Me.MaximizeBox = False
        Me.Name = "frm_mainmenu_A173823"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Menustrip.ResumeLayout(False)
        Me.Menustrip.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menustrip As MenuStrip
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductInfo As ToolStripMenuItem
    Friend WithEvents StaffInfo As ToolStripMenuItem
    Friend WithEvents CustomerInfo As ToolStripMenuItem
    Friend WithEvents OrderInfo As ToolStripMenuItem
    Friend WithEvents PurchaseInfo As ToolStripMenuItem
    Friend WithEvents CatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductCatalog As ToolStripMenuItem
    Friend WithEvents ProductInsert As ToolStripMenuItem
    Friend WithEvents StaffInsert As ToolStripMenuItem
    Friend WithEvents CustomerInsert As ToolStripMenuItem
    Friend WithEvents ProductUpdate As ToolStripMenuItem
    Friend WithEvents StaffUpdate As ToolStripMenuItem
    Friend WithEvents CustomerUpdate As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOrderToolStripMenuItem As ToolStripMenuItem
End Class
