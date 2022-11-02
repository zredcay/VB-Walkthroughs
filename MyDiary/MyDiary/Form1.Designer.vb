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
        Me.Submit = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.TextBox()
        Me.DisplayEntry = New System.Windows.Forms.TextBox()
        Me.Display = New System.Windows.Forms.Button()
        Me.GetEntries = New System.Windows.Forms.Button()
        Me.PickEntries = New System.Windows.Forms.ComboBox()
        Me.DeleteEntry = New System.Windows.Forms.Button()
        Me.EditEntry = New System.Windows.Forms.Button()
        Me.SubmitEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(12, 12)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(166, 29)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "Submit Entry"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(12, 47)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(166, 29)
        Me.Clear.TabIndex = 1
        Me.Clear.Text = "Clear Entry"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Entry
        '
        Me.Entry.Location = New System.Drawing.Point(12, 82)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(166, 27)
        Me.Entry.TabIndex = 2
        Me.Entry.Text = "Please enter something."
        '
        'DisplayEntry
        '
        Me.DisplayEntry.Location = New System.Drawing.Point(12, 115)
        Me.DisplayEntry.Multiline = True
        Me.DisplayEntry.Name = "DisplayEntry"
        Me.DisplayEntry.Size = New System.Drawing.Size(120, 60)
        Me.DisplayEntry.TabIndex = 3
        Me.DisplayEntry.Visible = False
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(12, 181)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(120, 29)
        Me.Display.TabIndex = 4
        Me.Display.Text = "Display"
        Me.Display.UseVisualStyleBackColor = True
        '
        'GetEntries
        '
        Me.GetEntries.Location = New System.Drawing.Point(12, 250)
        Me.GetEntries.Name = "GetEntries"
        Me.GetEntries.Size = New System.Drawing.Size(120, 29)
        Me.GetEntries.TabIndex = 5
        Me.GetEntries.Text = "Get Entries"
        Me.GetEntries.UseVisualStyleBackColor = True
        '
        'PickEntries
        '
        Me.PickEntries.Enabled = False
        Me.PickEntries.FormattingEnabled = True
        Me.PickEntries.Location = New System.Drawing.Point(12, 216)
        Me.PickEntries.Name = "PickEntries"
        Me.PickEntries.Size = New System.Drawing.Size(151, 28)
        Me.PickEntries.TabIndex = 6
        Me.PickEntries.Text = "Select an Entry"
        '
        'DeleteEntry
        '
        Me.DeleteEntry.Enabled = False
        Me.DeleteEntry.Location = New System.Drawing.Point(138, 115)
        Me.DeleteEntry.Name = "DeleteEntry"
        Me.DeleteEntry.Size = New System.Drawing.Size(112, 29)
        Me.DeleteEntry.TabIndex = 7
        Me.DeleteEntry.Text = "Delete Entry"
        Me.DeleteEntry.UseVisualStyleBackColor = True
        '
        'EditEntry
        '
        Me.EditEntry.Enabled = False
        Me.EditEntry.Location = New System.Drawing.Point(138, 146)
        Me.EditEntry.Name = "EditEntry"
        Me.EditEntry.Size = New System.Drawing.Size(112, 29)
        Me.EditEntry.TabIndex = 8
        Me.EditEntry.Text = "Edit Entry"
        Me.EditEntry.UseVisualStyleBackColor = True
        '
        'SubmitEdit
        '
        Me.SubmitEdit.Enabled = False
        Me.SubmitEdit.Location = New System.Drawing.Point(256, 146)
        Me.SubmitEdit.Name = "SubmitEdit"
        Me.SubmitEdit.Size = New System.Drawing.Size(112, 29)
        Me.SubmitEdit.TabIndex = 9
        Me.SubmitEdit.Text = "Submit Edit"
        Me.SubmitEdit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SubmitEdit)
        Me.Controls.Add(Me.EditEntry)
        Me.Controls.Add(Me.DeleteEntry)
        Me.Controls.Add(Me.PickEntries)
        Me.Controls.Add(Me.GetEntries)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.DisplayEntry)
        Me.Controls.Add(Me.Entry)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Submit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submit As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Entry As TextBox
    Friend WithEvents DisplayEntry As TextBox
    Friend WithEvents Display As Button
    Friend WithEvents GetEntries As Button
    Friend WithEvents PickEntries As ComboBox
    Friend WithEvents DeleteEntry As Button
    Friend WithEvents EditEntry As Button
    Friend WithEvents SubmitEdit As Button
End Class
