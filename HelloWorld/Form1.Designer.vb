<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSayIt = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Name:"
        '
        'cmdSayIt
        '
        Me.cmdSayIt.Location = New System.Drawing.Point(103, 78)
        Me.cmdSayIt.Name = "cmdSayIt"
        Me.cmdSayIt.Size = New System.Drawing.Size(75, 23)
        Me.cmdSayIt.TabIndex = 2
        Me.cmdSayIt.Text = "Say Hello"
        Me.cmdSayIt.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(78, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 20)
        Me.txtName.TabIndex = 3
        '
        'lblHowdy
        '
        Me.lblHowdy.Location = New System.Drawing.Point(12, 125)
        Me.lblHowdy.Name = "lblHowdy"
        Me.lblHowdy.Size = New System.Drawing.Size(249, 13)
        Me.lblHowdy.TabIndex = 4
        Me.lblHowdy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblHowdy)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdSayIt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hello World!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSayIt As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblHowdy As System.Windows.Forms.Label

End Class
