﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.MocaDi1 = New Moca.Win.MocaDi()
		Me.dgvResults = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtNote = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnUpd = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.DataBinder1 = New Moca.Win.DataBinder(Me.components)
		Me.btnClear = New System.Windows.Forms.Button()
		Me.DataBinder2 = New Moca.Demo.Win.Win.DataBinder(Me.components)
		Me.btnCancel = New System.Windows.Forms.Button()
		CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MocaDi1
		'
		Me.MocaDi1.AutoSize = True
		Me.MocaDi1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.MocaDi1.BackgroundImage = CType(resources.GetObject("MocaDi1.BackgroundImage"), System.Drawing.Image)
		Me.MocaDi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.MocaDi1.Location = New System.Drawing.Point(0, 0)
		Me.MocaDi1.Margin = New System.Windows.Forms.Padding(0)
		Me.MocaDi1.MaximumSize = New System.Drawing.Size(16, 16)
		Me.MocaDi1.MinimumSize = New System.Drawing.Size(16, 16)
		Me.MocaDi1.Name = "MocaDi1"
		Me.MocaDi1.Size = New System.Drawing.Size(16, 16)
		Me.MocaDi1.TabIndex = 0
		Me.MocaDi1.TabStop = False
		'
		'dgvResults
		'
		Me.dgvResults.AllowUserToAddRows = False
		Me.dgvResults.AllowUserToDeleteRows = False
		Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvResults.Location = New System.Drawing.Point(224, 9)
		Me.dgvResults.Name = "dgvResults"
		Me.dgvResults.ReadOnly = True
		Me.dgvResults.RowTemplate.Height = 21
		Me.dgvResults.Size = New System.Drawing.Size(355, 174)
		Me.dgvResults.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(16, 12)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(12, 24)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(115, 19)
		Me.txtID.TabIndex = 3
		'
		'txtCode
		'
		Me.txtCode.Location = New System.Drawing.Point(12, 61)
		Me.txtCode.Name = "txtCode"
		Me.txtCode.Size = New System.Drawing.Size(115, 19)
		Me.txtCode.TabIndex = 5
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 46)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(31, 12)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Code"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(12, 98)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(206, 19)
		Me.txtName.TabIndex = 7
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 83)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 12)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Name"
		'
		'txtNote
		'
		Me.txtNote.Location = New System.Drawing.Point(12, 135)
		Me.txtNote.Name = "txtNote"
		Me.txtNote.Size = New System.Drawing.Size(206, 19)
		Me.txtNote.TabIndex = 9
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 120)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(29, 12)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Note"
		'
		'btnUpd
		'
		Me.btnUpd.Location = New System.Drawing.Point(121, 160)
		Me.btnUpd.Name = "btnUpd"
		Me.btnUpd.Size = New System.Drawing.Size(97, 23)
		Me.btnUpd.TabIndex = 10
		Me.btnUpd.Text = "Update"
		Me.btnUpd.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(133, 9)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(85, 71)
		Me.btnSearch.TabIndex = 11
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'DataBinder1
		'
		Me.DataBinder1.DataMember = ""
		Me.DataBinder1.DataSource = Nothing
		Me.DataBinder1.Position = -1
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(12, 160)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(49, 23)
		Me.btnClear.TabIndex = 12
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'DataBinder2
		'
		Me.DataBinder2.DataMember = ""
		Me.DataBinder2.DataSource = Nothing
		Me.DataBinder2.Position = -1
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(67, 160)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(49, 23)
		Me.btnCancel.TabIndex = 13
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(591, 196)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.btnUpd)
		Me.Controls.Add(Me.txtNote)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtCode)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dgvResults)
		Me.Controls.Add(Me.MocaDi1)
		Me.Name = "Main"
		Me.Text = "Moca.NET Demo"
		CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MocaDi1 As Moca.Win.MocaDi
	Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtID As System.Windows.Forms.TextBox
	Friend WithEvents txtCode As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtName As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtNote As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents btnUpd As System.Windows.Forms.Button
	Friend WithEvents btnSearch As System.Windows.Forms.Button
	Friend WithEvents DataBinder1 As Moca.Win.DataBinder
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents DataBinder2 As Moca.Demo.Win.Win.DataBinder
	Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class