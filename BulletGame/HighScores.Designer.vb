<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.HighScoresDataSet = New BulletGame.HighScoresDataSet()
        Me.HighScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighScoresTableAdapter = New BulletGame.HighScoresDataSetTableAdapters.HighScoresTableAdapter()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharacterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighScoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvScores
        '
        Me.dgvScores.AutoGenerateColumns = False
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.PlayerNameDataGridViewTextBoxColumn, Me.ScoreDataGridViewTextBoxColumn, Me.CharacterDataGridViewTextBoxColumn})
        Me.dgvScores.DataSource = Me.HighScoresBindingSource
        Me.dgvScores.Location = New System.Drawing.Point(17, 16)
        Me.dgvScores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.ReadOnly = True
        Me.dgvScores.Size = New System.Drawing.Size(623, 482)
        Me.dgvScores.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(17, 506)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(133, 62)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(507, 506)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 62)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(158, 506)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 62)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'HighScoresDataSet
        '
        Me.HighScoresDataSet.DataSetName = "HighScoresDataSet"
        Me.HighScoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HighScoresBindingSource
        '
        Me.HighScoresBindingSource.DataMember = "HighScores"
        Me.HighScoresBindingSource.DataSource = Me.HighScoresDataSet
        '
        'HighScoresTableAdapter
        '
        Me.HighScoresTableAdapter.ClearBeforeFill = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'PlayerNameDataGridViewTextBoxColumn
        '
        Me.PlayerNameDataGridViewTextBoxColumn.DataPropertyName = "Player Name"
        Me.PlayerNameDataGridViewTextBoxColumn.HeaderText = "Player Name"
        Me.PlayerNameDataGridViewTextBoxColumn.Name = "PlayerNameDataGridViewTextBoxColumn"
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        '
        'CharacterDataGridViewTextBoxColumn
        '
        Me.CharacterDataGridViewTextBoxColumn.DataPropertyName = "Character"
        Me.CharacterDataGridViewTextBoxColumn.HeaderText = "Character"
        Me.CharacterDataGridViewTextBoxColumn.Name = "CharacterDataGridViewTextBoxColumn"
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 582)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvScores)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HighScores"
        Me.Text = "High Scores"
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighScoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvScores As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents HighScoresDataSet As HighScoresDataSet
    Friend WithEvents HighScoresBindingSource As BindingSource
    Friend WithEvents HighScoresTableAdapter As HighScoresDataSetTableAdapters.HighScoresTableAdapter
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CharacterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
