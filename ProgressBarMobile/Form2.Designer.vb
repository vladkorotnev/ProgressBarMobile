<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPrg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Notification = New Microsoft.WindowsCE.Forms.Notification
        Me.ass = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 144)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 28)
        '
        'Timer1
        '
        '
        'Notification
        '
        Me.Notification.Text = "Notification1"
        '
        'ass
        '
        Me.ass.Location = New System.Drawing.Point(0, 3)
        Me.ass.Name = "ass"
        Me.ass.Size = New System.Drawing.Size(240, 262)
        Me.ass.Visible = False
        '
        'frmPrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.ass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmPrg"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Notification As Microsoft.WindowsCE.Forms.Notification
    Friend WithEvents ass As System.Windows.Forms.WebBrowser
End Class
