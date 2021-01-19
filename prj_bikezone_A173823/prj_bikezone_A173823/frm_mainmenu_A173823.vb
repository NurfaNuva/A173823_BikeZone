Public Class frm_mainmenu_A173823
    Private Sub frm_mainmenu_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim current_date As String = Date.Now
        'lbl_date.Text = current_date
    End Sub

    Private Sub ProductInfo_Click(sender As Object, e As EventArgs) Handles ProductInfo.Click
        frm_productinfo_A173823.ShowDialog()
    End Sub

    Private Sub StaffInfo_Click(sender As Object, e As EventArgs) Handles StaffInfo.Click
        frm_staffinfo_A173823.ShowDialog()
    End Sub

    Private Sub CustomerInfo_Click(sender As Object, e As EventArgs) Handles CustomerInfo.Click
        frm_customerinfo_A173823.ShowDialog()
    End Sub

    Private Sub OrderInfo_Click(sender As Object, e As EventArgs) Handles OrderInfo.Click
        frm_orderinfo_A173823.ShowDialog()
    End Sub

    Private Sub PurchaseInfo_Click(sender As Object, e As EventArgs) Handles PurchaseInfo.Click
        frm_purchaseinfo_A173823.ShowDialog()
    End Sub

    Private Sub ProductCatalog_Click(sender As Object, e As EventArgs) Handles ProductCatalog.Click
        frm_productcatalog_A173823.ShowDialog()
    End Sub

    Private Sub ProductInsert_Click(sender As Object, e As EventArgs) Handles ProductInsert.Click
        frm_productinsert_A173823.ShowDialog()
    End Sub

    Private Sub StaffInsert_Click(sender As Object, e As EventArgs) Handles StaffInsert.Click
        frm_staffinsert_A173823.ShowDialog()
    End Sub

    Private Sub CustomerInsert_Click(sender As Object, e As EventArgs) Handles CustomerInsert.Click
        frm_customerinsert_A173823.ShowDialog()
    End Sub

    Private Sub ProductUpdate_Click(sender As Object, e As EventArgs) Handles ProductUpdate.Click
        frm_productedit_A173823.ShowDialog()
    End Sub

    Private Sub StaffUpdate_Click(sender As Object, e As EventArgs) Handles StaffUpdate.Click
        frm_staffedit_A173823.ShowDialog()
    End Sub

    Private Sub CustomerUpdate_Click(sender As Object, e As EventArgs) Handles CustomerUpdate.Click
        frm_customeredit_A173823.ShowDialog()
    End Sub

    Private Sub MakeOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeOrderToolStripMenuItem.Click
        frm_makeorder_A173823.ShowDialog()
    End Sub

    Private Sub ViewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrderToolStripMenuItem.Click
        frm_vieworder_A173823.ShowDialog()
    End Sub
End Class