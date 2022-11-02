<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.saveCheckBox = New System.Windows.Forms.CheckBox()
        Me.examineButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'filesListBox
        '
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.ItemHeight = 20
        Me.filesListBox.Location = New System.Drawing.Point(397, 47)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(150, 104)
        Me.filesListBox.TabIndex = 0
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(297, 47)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(94, 29)
        Me.browseButton.TabIndex = 1
        Me.browseButton.Text = "Browse"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'saveCheckBox
        '
        Me.saveCheckBox.AutoSize = True
        Me.saveCheckBox.Location = New System.Drawing.Point(279, 127)
        Me.saveCheckBox.Name = "saveCheckBox"
        Me.saveCheckBox.Size = New System.Drawing.Size(112, 24)
        Me.saveCheckBox.TabIndex = 2
        Me.saveCheckBox.Text = "Save Results"
        Me.saveCheckBox.UseVisualStyleBackColor = True
        '
        'examineButton
        '
        Me.examineButton.Location = New System.Drawing.Point(297, 82)
        Me.examineButton.Name = "examineButton"
        Me.examineButton.Size = New System.Drawing.Size(94, 29)
        Me.examineButton.TabIndex = 3
        Me.examineButton.Text = "Examine"
        Me.examineButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.examineButton)
        Me.Controls.Add(Me.saveCheckBox)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.filesListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filesListBox As ListBox
    Friend WithEvents browseButton As Button
    Friend WithEvents saveCheckBox As CheckBox
    Friend WithEvents examineButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
