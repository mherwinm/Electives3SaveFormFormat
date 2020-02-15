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
        Me.Status = New System.Windows.Forms.Label()
        Me.SaveJson = New System.Windows.Forms.Button()
        Me.SaveXml = New System.Windows.Forms.Button()
        Me.SaveTxt = New System.Windows.Forms.Button()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(270, 208)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(83, 24)
        Me.Status.TabIndex = 19
        Me.Status.Text = "HELLO!"
        '
        'SaveJson
        '
        Me.SaveJson.BackColor = System.Drawing.Color.Gray
        Me.SaveJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveJson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveJson.FlatAppearance.BorderSize = 0
        Me.SaveJson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveJson.Location = New System.Drawing.Point(410, 146)
        Me.SaveJson.Name = "SaveJson"
        Me.SaveJson.Size = New System.Drawing.Size(116, 33)
        Me.SaveJson.TabIndex = 18
        Me.SaveJson.Text = "JSON"
        Me.SaveJson.UseVisualStyleBackColor = False
        '
        'SaveXml
        '
        Me.SaveXml.BackColor = System.Drawing.Color.Gray
        Me.SaveXml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveXml.FlatAppearance.BorderSize = 0
        Me.SaveXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveXml.Location = New System.Drawing.Point(252, 146)
        Me.SaveXml.Name = "SaveXml"
        Me.SaveXml.Size = New System.Drawing.Size(116, 33)
        Me.SaveXml.TabIndex = 17
        Me.SaveXml.Text = "XML"
        Me.SaveXml.UseVisualStyleBackColor = False
        '
        'SaveTxt
        '
        Me.SaveTxt.BackColor = System.Drawing.Color.Gray
        Me.SaveTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveTxt.FlatAppearance.BorderSize = 0
        Me.SaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTxt.Location = New System.Drawing.Point(96, 146)
        Me.SaveTxt.Name = "SaveTxt"
        Me.SaveTxt.Size = New System.Drawing.Size(116, 33)
        Me.SaveTxt.TabIndex = 16
        Me.SaveTxt.Text = "TXT"
        Me.SaveTxt.UseVisualStyleBackColor = False
        '
        'TextAddress
        '
        Me.TextAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.Location = New System.Drawing.Point(107, 98)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(464, 26)
        Me.TextAddress.TabIndex = 15
        '
        'TextAge
        '
        Me.TextAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAge.Location = New System.Drawing.Point(107, 62)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(43, 26)
        Me.TextAge.TabIndex = 14
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(107, 25)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(318, 26)
        Me.TextName.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Age:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 265)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.SaveJson)
        Me.Controls.Add(Me.SaveXml)
        Me.Controls.Add(Me.SaveTxt)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Save Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Status As Label
    Friend WithEvents SaveJson As Button
    Friend WithEvents SaveXml As Button
    Friend WithEvents SaveTxt As Button
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents TextAge As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
