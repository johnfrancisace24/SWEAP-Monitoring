Public Class AdminDashboard
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles bttnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_MouseEnter(sender As Object, e As EventArgs) Handles bttnDash.MouseEnter
        bttnDash.FillColor = Color.FromArgb(255, 218, 0)
        bttnDash.ForeColor = Color.Black
        bttnDash.Image = My.Resources.dashboard__1_
        bttnDash.BorderColor = Color.Black
    End Sub

    Private Sub bttnDash_MouseLeave(sender As Object, e As EventArgs) Handles bttnDash.MouseLeave
        bttnDash.FillColor = Color.DarkRed
        bttnDash.ForeColor = Color.White
        bttnDash.Image = My.Resources.dash
        bttnDash.BorderColor = Color.White
    End Sub

    Private Sub bttnEmploy_MouseEnter(sender As Object, e As EventArgs) Handles bttnEmploy.MouseEnter
        bttnEmploy.FillColor = Color.FromArgb(255, 218, 0)
        bttnEmploy.ForeColor = Color.Black
        bttnEmploy.Image = My.Resources.company
        bttnEmploy.BorderColor = Color.Black
    End Sub

    Private Sub bttnEmploy_MouseLeave(sender As Object, e As EventArgs) Handles bttnEmploy.MouseLeave
        bttnEmploy.FillColor = Color.DarkRed
        bttnEmploy.ForeColor = Color.White
        bttnEmploy.Image = My.Resources.employees
        bttnEmploy.BorderColor = Color.White
    End Sub

    Private Sub bttnFund_MouseEnter(sender As Object, e As EventArgs) Handles bttnFund.MouseEnter
        bttnFund.FillColor = Color.FromArgb(255, 218, 0)
        bttnFund.ForeColor = Color.Black
        bttnFund.Image = My.Resources.fund__1_
        bttnFund.BorderColor = Color.Black
    End Sub

    Private Sub bttnFund_MouseLeave(sender As Object, e As EventArgs) Handles bttnFund.MouseLeave
        bttnFund.FillColor = Color.DarkRed
        bttnFund.ForeColor = Color.Wheat
        bttnFund.Image = My.Resources.transfer
        bttnFund.BorderColor = Color.White
    End Sub

    Private Sub bttnLogout_MouseEnter(sender As Object, e As EventArgs) Handles bttnLogout.MouseEnter
        bttnLogout.FillColor = Color.Red
        bttnLogout.ForeColor = Color.Black
    End Sub

    Private Sub bttnLogout_MouseLeave(sender As Object, e As EventArgs) Handles bttnLogout.MouseLeave
        bttnLogout.FillColor = Color.Transparent
        bttnLogout.ForeColor = Color.White
    End Sub

    Private Sub bttnDash_Click(sender As Object, e As EventArgs) Handles bttnDash.Click
        pnlD.BackColor = Color.FromArgb(255, 218, 0)
        pnlE.BackColor = Color.Transparent
        pnlT.BackColor = Color.Transparent


    End Sub

    Private Sub bttnEmploy_Click(sender As Object, e As EventArgs) Handles bttnEmploy.Click
        pnlD.BackColor = Color.Transparent
        pnlE.BackColor = Color.FromArgb(255, 218, 0)
        pnlT.BackColor = Color.Transparent
    End Sub

    Private Sub bttnFund_Click(sender As Object, e As EventArgs) Handles bttnFund.Click
        pnlD.BackColor = Color.Transparent
        pnlE.BackColor = Color.Transparent
        pnlT.BackColor = Color.FromArgb(255, 218, 0)
    End Sub
End Class