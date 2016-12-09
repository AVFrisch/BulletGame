<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameSettings
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboCharacter = New System.Windows.Forms.ComboBox()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.grpDiff = New System.Windows.Forms.GroupBox()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radMed = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tkbSpeed = New System.Windows.Forms.TrackBar()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.chkAudio = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad60 = New System.Windows.Forms.RadioButton()
        Me.rad30 = New System.Windows.Forms.RadioButton()
        Me.rad15 = New System.Windows.Forms.RadioButton()
        Me.chkGrid = New System.Windows.Forms.CheckBox()
        Me.grpDiff.SuspendLayout()
        CType(Me.tkbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(197, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(283, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Bullet Game"
        '
        'cboCharacter
        '
        Me.cboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCharacter.FormattingEnabled = True
        Me.cboCharacter.Items.AddRange(New Object() {"X - Basic", "O - Shielded", "V - Offensive"})
        Me.cboCharacter.Location = New System.Drawing.Point(195, 58)
        Me.cboCharacter.Name = "cboCharacter"
        Me.cboCharacter.Size = New System.Drawing.Size(204, 28)
        Me.cboCharacter.TabIndex = 1
        '
        'lblChar
        '
        Me.lblChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblChar.Font = New System.Drawing.Font("Lucida Console", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar.Location = New System.Drawing.Point(406, 58)
        Me.lblChar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(150, 150)
        Me.lblChar.TabIndex = 2
        Me.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(41, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Character:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(41, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Difficulty:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(13, 22)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(78, 24)
        Me.radEasy.TabIndex = 5
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'grpDiff
        '
        Me.grpDiff.Controls.Add(Me.radHard)
        Me.grpDiff.Controls.Add(Me.radMed)
        Me.grpDiff.Controls.Add(Me.radEasy)
        Me.grpDiff.Location = New System.Drawing.Point(197, 89)
        Me.grpDiff.Name = "grpDiff"
        Me.grpDiff.Size = New System.Drawing.Size(200, 111)
        Me.grpDiff.TabIndex = 6
        Me.grpDiff.TabStop = False
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(13, 75)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(78, 24)
        Me.radHard.TabIndex = 7
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radMed
        '
        Me.radMed.AutoSize = True
        Me.radMed.Checked = True
        Me.radMed.Location = New System.Drawing.Point(13, 49)
        Me.radMed.Name = "radMed"
        Me.radMed.Size = New System.Drawing.Size(102, 24)
        Me.radMed.TabIndex = 6
        Me.radMed.TabStop = True
        Me.radMed.Text = "Medium"
        Me.radMed.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(197, 214)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(200, 50)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.Location = New System.Drawing.Point(34, 239)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(150, 25)
        Me.btnOptions.TabIndex = 8
        Me.btnOptions.Text = "v More Options v"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Game Speed:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tkbSpeed
        '
        Me.tkbSpeed.Location = New System.Drawing.Point(194, 292)
        Me.tkbSpeed.Maximum = 20
        Me.tkbSpeed.Minimum = 5
        Me.tkbSpeed.Name = "tkbSpeed"
        Me.tkbSpeed.Size = New System.Drawing.Size(200, 56)
        Me.tkbSpeed.TabIndex = 10
        Me.tkbSpeed.Value = 10
        '
        'lblSpeed
        '
        Me.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpeed.Location = New System.Drawing.Point(403, 296)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(153, 24)
        Me.lblSpeed.TabIndex = 11
        Me.lblSpeed.Text = "10 t/s"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnScores
        '
        Me.btnScores.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScores.Location = New System.Drawing.Point(411, 239)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(150, 25)
        Me.btnScores.TabIndex = 12
        Me.btnScores.Text = "High Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'chkAudio
        '
        Me.chkAudio.AutoSize = True
        Me.chkAudio.Checked = True
        Me.chkAudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAudio.Location = New System.Drawing.Point(480, 348)
        Me.chkAudio.Name = "chkAudio"
        Me.chkAudio.Size = New System.Drawing.Size(91, 24)
        Me.chkAudio.TabIndex = 13
        Me.chkAudio.Text = "Audio"
        Me.chkAudio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(41, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Refresh Rate:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad60)
        Me.GroupBox1.Controls.Add(Me.rad30)
        Me.GroupBox1.Controls.Add(Me.rad15)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'rad60
        '
        Me.rad60.AutoSize = True
        Me.rad60.Location = New System.Drawing.Point(125, 18)
        Me.rad60.Name = "rad60"
        Me.rad60.Size = New System.Drawing.Size(54, 24)
        Me.rad60.TabIndex = 7
        Me.rad60.Text = "60"
        Me.rad60.UseVisualStyleBackColor = True
        '
        'rad30
        '
        Me.rad30.AutoSize = True
        Me.rad30.Checked = True
        Me.rad30.Location = New System.Drawing.Point(74, 18)
        Me.rad30.Name = "rad30"
        Me.rad30.Size = New System.Drawing.Size(54, 24)
        Me.rad30.TabIndex = 6
        Me.rad30.TabStop = True
        Me.rad30.Text = "30"
        Me.rad30.UseVisualStyleBackColor = True
        '
        'rad15
        '
        Me.rad15.AutoSize = True
        Me.rad15.Location = New System.Drawing.Point(23, 18)
        Me.rad15.Name = "rad15"
        Me.rad15.Size = New System.Drawing.Size(54, 24)
        Me.rad15.TabIndex = 5
        Me.rad15.Text = "15"
        Me.rad15.UseVisualStyleBackColor = True
        '
        'chkGrid
        '
        Me.chkGrid.AutoSize = True
        Me.chkGrid.Checked = True
        Me.chkGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGrid.Location = New System.Drawing.Point(480, 378)
        Me.chkGrid.Name = "chkGrid"
        Me.chkGrid.Size = New System.Drawing.Size(79, 24)
        Me.chkGrid.TabIndex = 15
        Me.chkGrid.Text = "Grid"
        Me.chkGrid.UseVisualStyleBackColor = True
        '
        'GameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 283)
        Me.Controls.Add(Me.chkGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkAudio)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.tkbSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpDiff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.cboCharacter)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "GameSettings"
        Me.Text = "Game Settings"
        Me.grpDiff.ResumeLayout(False)
        Me.grpDiff.PerformLayout()
        CType(Me.tkbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cboCharacter As ComboBox
    Friend WithEvents lblChar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents grpDiff As GroupBox
    Friend WithEvents radHard As RadioButton
    Friend WithEvents radMed As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tkbSpeed As TrackBar
    Friend WithEvents lblSpeed As Label
    Friend WithEvents btnScores As Button
    Friend WithEvents chkAudio As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad60 As RadioButton
    Friend WithEvents rad30 As RadioButton
    Friend WithEvents rad15 As RadioButton
    Friend WithEvents chkGrid As CheckBox
End Class
