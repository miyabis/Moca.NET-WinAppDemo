namespace MocaDemo
{
	partial class Index
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			Moca.GridDesignSettings gridDesignSettings1 = new Moca.GridDesignSettings();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtID = new Moca.Win.TextBoxEx(this.components);
			this.Label2 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtName = new Moca.Win.TextBoxEx(this.components);
			this.txtNote = new Moca.Win.TextBoxEx(this.components);
			this.DataBinder1 = new Moca.Win.DataBinder(this.components);
			this.Label5 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFindID = new Moca.Win.TextBoxEx(this.components);
			this.DebugMarker1 = new Moca.Win.DebugMarker();
			this.Label1 = new System.Windows.Forms.Label();
			this.grdFindResults = new Moca.Win.ModelGridView();
			this.mocaDi1 = new Moca.Win.MocaDi();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdFindResults)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txtID);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.txtNote);
			this.GroupBox1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.GroupBox1.Location = new System.Drawing.Point(353, 69);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(252, 151);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			// 
			// txtID
			// 
			this.txtID.BottomBorderColor = System.Drawing.Color.Empty;
			this.txtID.CustomChars = null;
			this.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtID.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None;
			this.txtID.Location = new System.Drawing.Point(67, 25);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtID.Name = "txtID";
			this.txtID.NegativeColor = System.Drawing.Color.Red;
			this.txtID.NumericScale = 0;
			this.txtID.Precision = 0;
			this.txtID.PrecisionSign = false;
			this.txtID.Required = false;
			this.txtID.Separator = "";
			this.txtID.Size = new System.Drawing.Size(175, 28);
			this.txtID.TabIndex = 0;
			this.txtID.Text = "TextBoxEx2";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(11, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(54, 29);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "ID : ";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(508, 229);
			this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(87, 29);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(11, 61);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(55, 29);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Name : ";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(11, 97);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(54, 29);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Note : ";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(419, 229);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(87, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtName
			// 
			this.txtName.BottomBorderColor = System.Drawing.Color.Empty;
			this.txtName.CustomChars = null;
			this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.txtName.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None;
			this.txtName.Location = new System.Drawing.Point(67, 61);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.NegativeColor = System.Drawing.Color.Red;
			this.txtName.NumericScale = 0;
			this.txtName.Precision = 0;
			this.txtName.PrecisionSign = false;
			this.txtName.Required = false;
			this.txtName.Separator = "";
			this.txtName.Size = new System.Drawing.Size(175, 28);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "TextBoxEx3";
			// 
			// txtNote
			// 
			this.txtNote.BottomBorderColor = System.Drawing.Color.Empty;
			this.txtNote.CustomChars = null;
			this.txtNote.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.txtNote.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None;
			this.txtNote.Location = new System.Drawing.Point(67, 97);
			this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNote.Name = "txtNote";
			this.txtNote.NegativeColor = System.Drawing.Color.Red;
			this.txtNote.NumericScale = 0;
			this.txtNote.Precision = 0;
			this.txtNote.PrecisionSign = false;
			this.txtNote.Required = false;
			this.txtNote.Separator = "";
			this.txtNote.Size = new System.Drawing.Size(175, 28);
			this.txtNote.TabIndex = 2;
			this.txtNote.Text = "TextBoxEx4";
			// 
			// DataBinder1
			// 
			this.DataBinder1.DataMember = "";
			this.DataBinder1.DataSource = null;
			this.DataBinder1.Position = -1;
			// 
			// Label5
			// 
			this.Label5.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.Label5.Location = new System.Drawing.Point(348, 10);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(257, 45);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "Moca.NET Sample";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnSearch.Location = new System.Drawing.Point(255, 33);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(87, 29);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFindID
			// 
			this.txtFindID.BottomBorderColor = System.Drawing.Color.Empty;
			this.txtFindID.CustomChars = null;
			this.txtFindID.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtFindID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtFindID.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None;
			this.txtFindID.Location = new System.Drawing.Point(48, 33);
			this.txtFindID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFindID.Name = "txtFindID";
			this.txtFindID.NegativeColor = System.Drawing.Color.Red;
			this.txtFindID.NumericScale = 0;
			this.txtFindID.Precision = 0;
			this.txtFindID.PrecisionSign = false;
			this.txtFindID.Required = false;
			this.txtFindID.Separator = "";
			this.txtFindID.Size = new System.Drawing.Size(201, 28);
			this.txtFindID.TabIndex = 0;
			this.txtFindID.Text = "TextBoxEx1";
			// 
			// DebugMarker1
			// 
			this.DebugMarker1.BackColor = System.Drawing.Color.Transparent;
			this.DebugMarker1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DebugMarker1.BackgroundImage")));
			this.DebugMarker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.DebugMarker1.Location = new System.Drawing.Point(0, 0);
			this.DebugMarker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DebugMarker1.MaximumSize = new System.Drawing.Size(19, 20);
			this.DebugMarker1.MinimumSize = new System.Drawing.Size(19, 20);
			this.DebugMarker1.Name = "DebugMarker1";
			this.DebugMarker1.Size = new System.Drawing.Size(19, 20);
			this.DebugMarker1.TabIndex = 15;
			this.DebugMarker1.TabStop = false;
			this.DebugMarker1.ToolTipText = null;
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Label1.Location = new System.Drawing.Point(13, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(31, 29);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "ID : ";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grdFindResults
			// 
			this.grdFindResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdFindResults.DefaultCellStyle = dataGridViewCellStyle1;
			gridDesignSettings1.SettingsKey = "";
			this.grdFindResults.DesignSettings = gridDesignSettings1;
			this.grdFindResults.Location = new System.Drawing.Point(13, 69);
			this.grdFindResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.grdFindResults.Name = "grdFindResults";
			this.grdFindResults.RowEditImage = ((System.Drawing.Image)(resources.GetObject("grdFindResults.RowEditImage")));
			this.grdFindResults.RowEntityType = null;
			this.grdFindResults.RowTemplate.Height = 21;
			this.grdFindResults.Size = new System.Drawing.Size(329, 151);
			this.grdFindResults.Styles = ((System.Collections.Generic.IDictionary<string, System.Windows.Forms.DataGridViewCellStyle>)(resources.GetObject("grdFindResults.Styles")));
			this.grdFindResults.TabIndex = 2;
			this.grdFindResults.TransparentRowSelection = false;
			this.grdFindResults.GridColmnSetting += new Moca.Win.ModelGridView.GridColmnSettingEventHandler(this.grdFindResults_GridColmnSetting);
			// 
			// mocaDi1
			// 
			this.mocaDi1.AutoSize = true;
			this.mocaDi1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mocaDi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mocaDi1.BackgroundImage")));
			this.mocaDi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.mocaDi1.Location = new System.Drawing.Point(22, 0);
			this.mocaDi1.Margin = new System.Windows.Forms.Padding(0);
			this.mocaDi1.MaximumSize = new System.Drawing.Size(16, 16);
			this.mocaDi1.MinimumSize = new System.Drawing.Size(16, 16);
			this.mocaDi1.Name = "mocaDi1";
			this.mocaDi1.Size = new System.Drawing.Size(16, 16);
			this.mocaDi1.TabIndex = 20;
			this.mocaDi1.TabStop = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(13, 229);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(87, 29);
			this.btnUpdate.TabIndex = 21;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 282);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.DebugMarker1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.mocaDi1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtFindID);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.grdFindResults);
			this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Index";
			this.Text = "Moca.NET Demo";
			this.Load += new System.EventHandler(this.Index_Load);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdFindResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox1;
		internal Moca.Win.TextBoxEx txtID;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button btnAdd;
		internal Moca.Win.TextBoxEx txtName;
		internal Moca.Win.TextBoxEx txtNote;
		internal Moca.Win.DataBinder DataBinder1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button btnSearch;
		internal Moca.Win.TextBoxEx txtFindID;
		internal Moca.Win.DebugMarker DebugMarker1;
		internal System.Windows.Forms.Label Label1;
		internal Moca.Win.ModelGridView grdFindResults;
		private Moca.Win.MocaDi mocaDi1;
		internal System.Windows.Forms.Button btnUpdate;
	}
}

