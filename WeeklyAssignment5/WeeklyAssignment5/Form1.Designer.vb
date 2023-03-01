<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WeeklyAssignment5
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
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbGroup = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbRegister = New System.Windows.Forms.Label()
        Me.lbCost = New System.Windows.Forms.Label()
        Me.rbtnSuper = New System.Windows.Forms.RadioButton()
        Me.rbtnAuto = New System.Windows.Forms.RadioButton()
        Me.rbtnCon = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbBadge = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBadge.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbTitle.Location = New System.Drawing.Point(101, 169)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(484, 45)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Comic Convention Registration"
        '
        'lbGroup
        '
        Me.lbGroup.AutoSize = True
        Me.lbGroup.Font = New System.Drawing.Font("Coolsville", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbGroup.Location = New System.Drawing.Point(192, 248)
        Me.lbGroup.Name = "lbGroup"
        Me.lbGroup.Size = New System.Drawing.Size(124, 23)
        Me.lbGroup.TabIndex = 1
        Me.lbGroup.Text = "Group Size:"
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Coolsville", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtSize.Location = New System.Drawing.Point(362, 245)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(70, 31)
        Me.txtSize.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(109, 559)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(177, 47)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(362, 559)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(191, 47)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lbRegister
        '
        Me.lbRegister.AutoSize = True
        Me.lbRegister.Font = New System.Drawing.Font("Bastion", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegister.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbRegister.Location = New System.Drawing.Point(148, 477)
        Me.lbRegister.Name = "lbRegister"
        Me.lbRegister.Size = New System.Drawing.Size(203, 25)
        Me.lbRegister.TabIndex = 5
        Me.lbRegister.Text = "Registration Cost:"
        '
        'lbCost
        '
        Me.lbCost.AutoSize = True
        Me.lbCost.Font = New System.Drawing.Font("Bastion", 15.75!)
        Me.lbCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbCost.Location = New System.Drawing.Point(418, 477)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(93, 25)
        Me.lbCost.TabIndex = 6
        Me.lbCost.Text = "Amount"
        '
        'rbtnSuper
        '
        Me.rbtnSuper.AutoSize = True
        Me.rbtnSuper.Location = New System.Drawing.Point(19, 25)
        Me.rbtnSuper.Name = "rbtnSuper"
        Me.rbtnSuper.Size = New System.Drawing.Size(340, 23)
        Me.rbtnSuper.TabIndex = 8
        Me.rbtnSuper.TabStop = True
        Me.rbtnSuper.Text = "Convention + Superhero Experience"
        Me.rbtnSuper.UseVisualStyleBackColor = True
        '
        'rbtnAuto
        '
        Me.rbtnAuto.AutoSize = True
        Me.rbtnAuto.Location = New System.Drawing.Point(18, 67)
        Me.rbtnAuto.Name = "rbtnAuto"
        Me.rbtnAuto.Size = New System.Drawing.Size(246, 23)
        Me.rbtnAuto.TabIndex = 9
        Me.rbtnAuto.TabStop = True
        Me.rbtnAuto.Text = "Convention + Autographs"
        Me.rbtnAuto.UseVisualStyleBackColor = True
        '
        'rbtnCon
        '
        Me.rbtnCon.AutoSize = True
        Me.rbtnCon.Location = New System.Drawing.Point(19, 110)
        Me.rbtnCon.Name = "rbtnCon"
        Me.rbtnCon.Size = New System.Drawing.Size(127, 23)
        Me.rbtnCon.TabIndex = 10
        Me.rbtnCon.TabStop = True
        Me.rbtnCon.Text = "Convention"
        Me.rbtnCon.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment5.My.Resources.Resources.comic
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'gbBadge
        '
        Me.gbBadge.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbBadge.Controls.Add(Me.rbtnCon)
        Me.gbBadge.Controls.Add(Me.rbtnAuto)
        Me.gbBadge.Controls.Add(Me.rbtnSuper)
        Me.gbBadge.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBadge.ForeColor = System.Drawing.Color.OrangeRed
        Me.gbBadge.Location = New System.Drawing.Point(121, 300)
        Me.gbBadge.Name = "gbBadge"
        Me.gbBadge.Size = New System.Drawing.Size(423, 150)
        Me.gbBadge.TabIndex = 12
        Me.gbBadge.TabStop = False
        Me.gbBadge.Text = "Select Badge Type:"
        '
        'WeeklyAssignment5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 660)
        Me.Controls.Add(Me.lbCost)
        Me.Controls.Add(Me.lbRegister)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lbGroup)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbBadge)
        Me.Name = "WeeklyAssignment5"
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBadge.ResumeLayout(False)
        Me.gbBadge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitle As Label
    Friend WithEvents lbGroup As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lbRegister As Label
    Friend WithEvents lbCost As Label
    Friend WithEvents rbtnSuper As RadioButton
    Friend WithEvents rbtnAuto As RadioButton
    Friend WithEvents rbtnCon As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbBadge As GroupBox
End Class
