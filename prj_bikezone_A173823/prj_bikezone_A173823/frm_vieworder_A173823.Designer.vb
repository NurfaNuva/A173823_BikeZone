<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_A173823
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
        Me.cmb_orderid = New System.Windows.Forms.ComboBox()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_purchase = New System.Windows.Forms.DataGridView()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.grd_purchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_orderid
        '
        Me.cmb_orderid.BackColor = System.Drawing.Color.Crimson
        Me.cmb_orderid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_orderid.ForeColor = System.Drawing.Color.White
        Me.cmb_orderid.FormattingEnabled = True
        Me.cmb_orderid.Location = New System.Drawing.Point(172, 101)
        Me.cmb_orderid.MaxDropDownItems = 10
        Me.cmb_orderid.Name = "cmb_orderid"
        Me.cmb_orderid.Size = New System.Drawing.Size(157, 33)
        Me.cmb_orderid.TabIndex = 46
        '
        'txt_custid
        '
        Me.txt_custid.BackColor = System.Drawing.Color.Crimson
        Me.txt_custid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custid.ForeColor = System.Drawing.Color.White
        Me.txt_custid.Location = New System.Drawing.Point(860, 101)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(157, 30)
        Me.txt_custid.TabIndex = 45
        Me.txt_custid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_staffid
        '
        Me.txt_staffid.BackColor = System.Drawing.Color.Crimson
        Me.txt_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.ForeColor = System.Drawing.Color.White
        Me.txt_staffid.Location = New System.Drawing.Point(494, 103)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(157, 30)
        Me.txt_staffid.TabIndex = 44
        Me.txt_staffid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(686, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(364, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Staff ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Order ID"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_title.Location = New System.Drawing.Point(416, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(231, 37)
        Me.lbl_title.TabIndex = 47
        Me.lbl_title.Text = "View Order"
        '
        'grd_purchase
        '
        Me.grd_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_purchase.Location = New System.Drawing.Point(40, 188)
        Me.grd_purchase.Name = "grd_purchase"
        Me.grd_purchase.RowHeadersWidth = 51
        Me.grd_purchase.RowTemplate.Height = 24
        Me.grd_purchase.Size = New System.Drawing.Size(977, 257)
        Me.grd_purchase.TabIndex = 48
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Crimson
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(807, 468)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(210, 38)
        Me.txt_total.TabIndex = 50
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(684, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 31)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Total"
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_print.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Location = New System.Drawing.Point(435, 532)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(192, 48)
        Me.btn_print.TabIndex = 67
        Me.btn_print.Text = "Print Invoice"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'frm_vieworder_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1062, 592)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grd_purchase)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.cmb_orderid)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_vieworder_A173823"
        Me.Text = "View Order"
        CType(Me.grd_purchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_orderid As ComboBox
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_purchase As DataGridView
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_print As Button
End Class
