<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_purchaseinfo_A173823
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
        Me.grd_purchaseinfo = New System.Windows.Forms.DataGridView()
        CType(Me.grd_purchaseinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_title.Location = New System.Drawing.Point(176, 11)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(438, 37)
        Me.lbl_title.TabIndex = 18
        Me.lbl_title.Text = "Purchase Information"
        '
        'grd_purchaseinfo
        '
        Me.grd_purchaseinfo.AllowUserToAddRows = False
        Me.grd_purchaseinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_purchaseinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_purchaseinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_purchaseinfo.GridColor = System.Drawing.Color.DarkRed
        Me.grd_purchaseinfo.Location = New System.Drawing.Point(12, 82)
        Me.grd_purchaseinfo.Name = "grd_purchaseinfo"
        Me.grd_purchaseinfo.ReadOnly = True
        Me.grd_purchaseinfo.RowHeadersWidth = 51
        Me.grd_purchaseinfo.RowTemplate.Height = 24
        Me.grd_purchaseinfo.Size = New System.Drawing.Size(776, 358)
        Me.grd_purchaseinfo.TabIndex = 17
        '
        'frm_purchaseinfo_A173823
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_purchaseinfo)
        Me.Name = "frm_purchaseinfo_A173823"
        Me.Text = "Purchase Information"
        CType(Me.grd_purchaseinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_purchaseinfo As DataGridView
End Class
