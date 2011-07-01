<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.title = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.min = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.sec = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.endchk = New System.Windows.Forms.CheckBox
        Me.endact = New System.Windows.Forms.ComboBox
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog
        Me.Notification = New Microsoft.WindowsCE.Forms.Notification
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.browsebtn = New System.Windows.Forms.Button
        Me.OpenFilePar = New System.Windows.Forms.TextBox
        Me.msgpar = New System.Windows.Forms.TextBox
        Me.url = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem3)
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Start"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.Text = "Title:"
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(46, 2)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(191, 21)
        Me.title.TabIndex = 1
        Me.title.Text = "Deleting all files"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.Text = "Time:"
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(46, 45)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(25, 21)
        Me.min.TabIndex = 3
        Me.min.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(78, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 20)
        Me.Label3.Text = "min."
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(126, 44)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(37, 21)
        Me.sec.TabIndex = 5
        Me.sec.Text = "1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(170, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.Text = "sec."
        '
        'endchk
        '
        Me.endchk.Location = New System.Drawing.Point(6, 72)
        Me.endchk.Name = "endchk"
        Me.endchk.Size = New System.Drawing.Size(100, 20)
        Me.endchk.TabIndex = 7
        Me.endchk.Text = "End action:"
        '
        'endact
        '
        Me.endact.Items.Add("Show Message")
        Me.endact.Items.Add("Show Notification")
        Me.endact.Items.Add("Open web page")
        Me.endact.Location = New System.Drawing.Point(106, 72)
        Me.endact.Name = "endact"
        Me.endact.Size = New System.Drawing.Size(120, 22)
        Me.endact.TabIndex = 8
        '
        'Notification
        '
        Me.Notification.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.browsebtn)
        Me.Panel1.Controls.Add(Me.OpenFilePar)
        Me.Panel1.Controls.Add(Me.msgpar)
        Me.Panel1.Controls.Add(Me.url)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(6, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 70)
        '
        'browsebtn
        '
        Me.browsebtn.Location = New System.Drawing.Point(195, 22)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(22, 22)
        Me.browsebtn.TabIndex = 4
        Me.browsebtn.Text = "..."
        '
        'OpenFilePar
        '
        Me.OpenFilePar.Location = New System.Drawing.Point(4, 23)
        Me.OpenFilePar.Name = "OpenFilePar"
        Me.OpenFilePar.Size = New System.Drawing.Size(192, 21)
        Me.OpenFilePar.TabIndex = 3
        Me.OpenFilePar.Text = "File"
        '
        'msgpar
        '
        Me.msgpar.Location = New System.Drawing.Point(4, 22)
        Me.msgpar.Name = "msgpar"
        Me.msgpar.Size = New System.Drawing.Size(213, 21)
        Me.msgpar.TabIndex = 2
        Me.msgpar.Text = "Message"
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(3, 23)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(214, 21)
        Me.url.TabIndex = 1
        Me.url.Text = "URL"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 20)
        Me.Label5.Text = "Action parameter:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.endact)
        Me.Controls.Add(Me.endchk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "ProgressBar mobile"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents endchk As System.Windows.Forms.CheckBox
    Friend WithEvents endact As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Notification As Microsoft.WindowsCE.Forms.Notification
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents msgpar As System.Windows.Forms.TextBox
    Friend WithEvents url As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents browsebtn As System.Windows.Forms.Button
    Friend WithEvents OpenFilePar As System.Windows.Forms.TextBox

End Class
