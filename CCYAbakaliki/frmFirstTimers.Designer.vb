<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstTimers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstTimers))
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCA = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtPrayerRequest = New System.Windows.Forms.TextBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtNames = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPoC = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(262, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 51
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCA
        '
        Me.btnCA.Location = New System.Drawing.Point(164, 308)
        Me.btnCA.Name = "btnCA"
        Me.btnCA.Size = New System.Drawing.Size(75, 23)
        Me.btnCA.TabIndex = 50
        Me.btnCA.Text = "Clear All"
        Me.btnCA.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(65, 308)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPrayerRequest
        '
        Me.txtPrayerRequest.Location = New System.Drawing.Point(164, 220)
        Me.txtPrayerRequest.Multiline = True
        Me.txtPrayerRequest.Name = "txtPrayerRequest"
        Me.txtPrayerRequest.Size = New System.Drawing.Size(200, 64)
        Me.txtPrayerRequest.TabIndex = 47
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(164, 152)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(200, 20)
        Me.txtPN.TabIndex = 46
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(164, 90)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 58)
        Me.txtAddress.TabIndex = 45
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(164, 64)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(200, 20)
        Me.txtNames.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "First Timers/Visitors Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Prayer Request"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Purpose of Coming"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Names"
        '
        'txtPoC
        '
        Me.txtPoC.Location = New System.Drawing.Point(164, 176)
        Me.txtPoC.Multiline = True
        Me.txtPoC.Name = "txtPoC"
        Me.txtPoC.Size = New System.Drawing.Size(200, 38)
        Me.txtPoC.TabIndex = 52
        '
        'frmFirstTimers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.txtPoC)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCA)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPrayerRequest)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFirstTimers"
        Me.Text = "First Timers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCA As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPrayerRequest As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPoC As System.Windows.Forms.TextBox
End Class
