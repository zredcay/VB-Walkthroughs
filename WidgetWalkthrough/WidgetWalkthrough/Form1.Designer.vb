Imports System.Runtime.CompilerServices

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PercentDone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Task"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PercentDone
        '
        Me.PercentDone.AutoSize = True
        Me.PercentDone.Location = New System.Drawing.Point(12, 7)
        Me.PercentDone.Name = "PercentDone"
        Me.PercentDone.Size = New System.Drawing.Size(17, 20)
        Me.PercentDone.TabIndex = 2
        Me.PercentDone.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PercentDone)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PercentDone As Label
    Private WithEvents mWidget As Widget
    Private mblnCancel As Boolean

    Private Sub mWidget_PercentDone(
                                   ByVal Percent As Single,
                                   ByRef Cancel As Boolean
                                   ) Handles mWidget.PercentDone
        PercentDone.Text = CInt(100 * Percent) & "%"
        My.Application.DoEvents()
        If mblnCancel Then Cancel = True
    End Sub

    Private Sub Button2_Click(
                             ByVal sender As Object,
                             ByVal e As System.EventArgs
                             ) Handles Button2.Click
        mblnCancel = True
    End Sub

    Private Sub Form1_Load(
                          ByVal sender As System.Object,
                          ByVal e As System.EventArgs
                          ) Handles MyBase.Load
        mWidget = New Widget
    End Sub
    Private Sub Button1_Click(
                             ByVal sender As Object,
                             ByVal e As System.EventArgs
                             ) Handles Button1.Click
        mblnCancel = False
        PercentDone.Text = "0%"
        PercentDone.Refresh()
        ' Create a new Widget object.
        mWidget = New Widget
        mWidget.LongTask(12.2, 0.33)
        If Not mblnCancel Then PercentDone.Text = CStr(100) & "%"
    End Sub
End Class
