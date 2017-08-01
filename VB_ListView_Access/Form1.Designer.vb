Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroForm

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
        Me.mListView = New System.Windows.Forms.ListView()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.propellantTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.destinationTxt = New MetroFramework.Controls.MetroTextBox()
        Me.addBtn = New MetroFramework.Controls.MetroButton()
        Me.retrieveBtn = New MetroFramework.Controls.MetroButton()
        Me.updateBtn = New MetroFramework.Controls.MetroButton()
        Me.deleteBtn = New MetroFramework.Controls.MetroButton()
        Me.clearBtn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'mListView
        '
        Me.mListView.Location = New System.Drawing.Point(24, 106)
        Me.mListView.Name = "mListView"
        Me.mListView.Size = New System.Drawing.Size(557, 349)
        Me.mListView.TabIndex = 0
        Me.mListView.UseCompatibleStateImageBehavior = False
        '
        'nameTxt
        '
        '
        '
        '
        Me.nameTxt.CustomButton.Image = Nothing
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(731, 116)
        Me.nameTxt.MaxLength = 32767
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(147, 23)
        Me.nameTxt.TabIndex = 1
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(620, 120)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(620, 174)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Propellant"
        '
        'propellantTxt
        '
        '
        '
        '
        Me.propellantTxt.CustomButton.Image = Nothing
        Me.propellantTxt.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.propellantTxt.CustomButton.Name = ""
        Me.propellantTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.propellantTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.propellantTxt.CustomButton.TabIndex = 1
        Me.propellantTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.propellantTxt.CustomButton.UseSelectable = True
        Me.propellantTxt.CustomButton.Visible = False
        Me.propellantTxt.Lines = New String(-1) {}
        Me.propellantTxt.Location = New System.Drawing.Point(731, 170)
        Me.propellantTxt.MaxLength = 32767
        Me.propellantTxt.Name = "propellantTxt"
        Me.propellantTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.propellantTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.propellantTxt.SelectedText = ""
        Me.propellantTxt.SelectionLength = 0
        Me.propellantTxt.SelectionStart = 0
        Me.propellantTxt.ShortcutsEnabled = True
        Me.propellantTxt.Size = New System.Drawing.Size(147, 23)
        Me.propellantTxt.TabIndex = 3
        Me.propellantTxt.UseSelectable = True
        Me.propellantTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.propellantTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(620, 239)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Destination"
        '
        'destinationTxt
        '
        '
        '
        '
        Me.destinationTxt.CustomButton.Image = Nothing
        Me.destinationTxt.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.destinationTxt.CustomButton.Name = ""
        Me.destinationTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.destinationTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.destinationTxt.CustomButton.TabIndex = 1
        Me.destinationTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.destinationTxt.CustomButton.UseSelectable = True
        Me.destinationTxt.CustomButton.Visible = False
        Me.destinationTxt.Lines = New String(-1) {}
        Me.destinationTxt.Location = New System.Drawing.Point(731, 235)
        Me.destinationTxt.MaxLength = 32767
        Me.destinationTxt.Name = "destinationTxt"
        Me.destinationTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.destinationTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.destinationTxt.SelectedText = ""
        Me.destinationTxt.SelectionLength = 0
        Me.destinationTxt.SelectionStart = 0
        Me.destinationTxt.ShortcutsEnabled = True
        Me.destinationTxt.Size = New System.Drawing.Size(147, 23)
        Me.destinationTxt.TabIndex = 5
        Me.destinationTxt.UseSelectable = True
        Me.destinationTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.destinationTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(620, 314)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(111, 23)
        Me.addBtn.TabIndex = 7
        Me.addBtn.Text = "Add"
        Me.addBtn.UseSelectable = True
        '
        'retrieveBtn
        '
        Me.retrieveBtn.Location = New System.Drawing.Point(764, 314)
        Me.retrieveBtn.Name = "retrieveBtn"
        Me.retrieveBtn.Size = New System.Drawing.Size(114, 23)
        Me.retrieveBtn.TabIndex = 8
        Me.retrieveBtn.Text = "Retrieve"
        Me.retrieveBtn.UseSelectable = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(620, 369)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(111, 23)
        Me.updateBtn.TabIndex = 9
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseSelectable = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(764, 369)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(114, 23)
        Me.deleteBtn.TabIndex = 10
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseSelectable = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(688, 420)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(111, 23)
        Me.clearBtn.TabIndex = 11
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 532)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.retrieveBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.destinationTxt)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.propellantTxt)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.mListView)
        Me.Name = "Form1"
        Me.Text = "VB.NET ListView MS Access CRUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mListView As System.Windows.Forms.ListView
    Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents propellantTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents destinationTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents addBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents retrieveBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents updateBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents deleteBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents clearBtn As MetroFramework.Controls.MetroButton

End Class
