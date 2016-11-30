Option Strict On

Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmdSayIt.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdSayIt_Click(sender As System.Object, e As System.EventArgs) Handles cmdSayIt.Click
        lblGreeting.Text = String.Format("Hello {0}!", Trim(txtName.Text))
    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
        cmdSayIt.Enabled = Not String.IsNullOrEmpty(txtName.Text) And Regex.Match(txtName.Text, "[^\s]").Success
    End Sub
End Class
