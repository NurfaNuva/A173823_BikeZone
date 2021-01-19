Public Class frm_makeorder_A173823
    Private Sub frm_makeorder_A173823_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_orderid()
        txt_staffid.Text = generate_staffid()
        generate_custid()
        refresh_custname(cmb_custid.Text)

        Dim current_date As String = Date.Now
        txt_orderdate.Text = current_date

    End Sub

    Private Sub generate_orderid()
        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A173823"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("LASTID")
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

    Private Sub refresh_custname(cust_name As String)
        Dim mysql = run_sql_query("SELECT * FROM TBL_CUSTOMER_A173823 WHERE FLD_CUSTOMER_ID='" & cust_name & "'")
        txt_custname.Text = mysql.Rows(0).Item("FLD_CUSTOMER_NAME")
    End Sub

    Private Sub cmb_custid_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_custid.MouseClick
        refresh_custname(cmb_custid.Text)
    End Sub

    Private Sub frm_makeorder_A173823_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class