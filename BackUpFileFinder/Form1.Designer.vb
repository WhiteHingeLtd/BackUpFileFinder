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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.XandTPanel = New System.Windows.Forms.Panel()
        Me.TandXbackuppath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetTandEListBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TandXBackupCountLbl = New System.Windows.Forms.Label()
        Me.TandXMostRecentLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.XandTDGV = New System.Windows.Forms.DataGridView()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XandTPanel.SuspendLayout()
        CType(Me.XandTDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XandTPanel
        '
        Me.XandTPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XandTPanel.Controls.Add(Me.Label5)
        Me.XandTPanel.Controls.Add(Me.TandXMostRecentLbl)
        Me.XandTPanel.Controls.Add(Me.Label4)
        Me.XandTPanel.Controls.Add(Me.TandXBackupCountLbl)
        Me.XandTPanel.Controls.Add(Me.Label2)
        Me.XandTPanel.Controls.Add(Me.GetTandEListBtn)
        Me.XandTPanel.Controls.Add(Me.Label1)
        Me.XandTPanel.Controls.Add(Me.TandXbackuppath)
        Me.XandTPanel.Location = New System.Drawing.Point(12, 12)
        Me.XandTPanel.Name = "XandTPanel"
        Me.XandTPanel.Size = New System.Drawing.Size(535, 55)
        Me.XandTPanel.TabIndex = 0
        '
        'TandXbackuppath
        '
        Me.TandXbackuppath.Location = New System.Drawing.Point(109, 27)
        Me.TandXbackuppath.Name = "TandXbackuppath"
        Me.TandXbackuppath.ReadOnly = True
        Me.TandXbackuppath.Size = New System.Drawing.Size(116, 20)
        Me.TandXbackuppath.TabIndex = 0
        Me.TandXbackuppath.Text = "\\Vhost-1\e\T and X\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Finding backups at:"
        '
        'GetTandEListBtn
        '
        Me.GetTandEListBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetTandEListBtn.Location = New System.Drawing.Point(231, 15)
        Me.GetTandEListBtn.Name = "GetTandEListBtn"
        Me.GetTandEListBtn.Size = New System.Drawing.Size(75, 32)
        Me.GetTandEListBtn.TabIndex = 2
        Me.GetTandEListBtn.Text = "Get List"
        Me.GetTandEListBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Backups Found:"
        '
        'TandXBackupCountLbl
        '
        Me.TandXBackupCountLbl.AutoSize = True
        Me.TandXBackupCountLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TandXBackupCountLbl.Location = New System.Drawing.Point(451, 15)
        Me.TandXBackupCountLbl.Name = "TandXBackupCountLbl"
        Me.TandXBackupCountLbl.Size = New System.Drawing.Size(29, 16)
        Me.TandXBackupCountLbl.TabIndex = 4
        Me.TandXBackupCountLbl.Text = "###"
        '
        'TandXMostRecentLbl
        '
        Me.TandXMostRecentLbl.AutoSize = True
        Me.TandXMostRecentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TandXMostRecentLbl.Location = New System.Drawing.Point(451, 31)
        Me.TandXMostRecentLbl.Name = "TandXMostRecentLbl"
        Me.TandXMostRecentLbl.Size = New System.Drawing.Size(29, 16)
        Me.TandXMostRecentLbl.TabIndex = 6
        Me.TandXMostRecentLbl.Text = "###"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Most Recent Found:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "X and T drive backups"
        '
        'XandTDGV
        '
        Me.XandTDGV.AllowUserToAddRows = False
        Me.XandTDGV.AllowUserToDeleteRows = False
        Me.XandTDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XandTDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.XandTDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameCol, Me.DateCol, Me.SizeCol, Me.SpecialCol})
        Me.XandTDGV.Location = New System.Drawing.Point(12, 73)
        Me.XandTDGV.Name = "XandTDGV"
        Me.XandTDGV.RowHeadersVisible = False
        Me.XandTDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.XandTDGV.Size = New System.Drawing.Size(535, 267)
        Me.XandTDGV.TabIndex = 1
        '
        'NameCol
        '
        Me.NameCol.HeaderText = "Name"
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        Me.NameCol.Width = 180
        '
        'DateCol
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DateCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.DateCol.HeaderText = "Date"
        Me.DateCol.Name = "DateCol"
        Me.DateCol.ReadOnly = True
        Me.DateCol.Width = 90
        '
        'SizeCol
        '
        Me.SizeCol.HeaderText = "Size (MB)"
        Me.SizeCol.Name = "SizeCol"
        Me.SizeCol.ReadOnly = True
        '
        'SpecialCol
        '
        Me.SpecialCol.HeaderText = "Special"
        Me.SpecialCol.Name = "SpecialCol"
        Me.SpecialCol.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 352)
        Me.Controls.Add(Me.XandTDGV)
        Me.Controls.Add(Me.XandTPanel)
        Me.Name = "Form1"
        Me.Text = "Back Up File Finder"
        Me.XandTPanel.ResumeLayout(False)
        Me.XandTPanel.PerformLayout()
        CType(Me.XandTDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XandTPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TandXMostRecentLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TandXBackupCountLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GetTandEListBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TandXbackuppath As TextBox
    Friend WithEvents XandTDGV As DataGridView
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
    Friend WithEvents DateCol As DataGridViewTextBoxColumn
    Friend WithEvents SizeCol As DataGridViewTextBoxColumn
    Friend WithEvents SpecialCol As DataGridViewTextBoxColumn
End Class
