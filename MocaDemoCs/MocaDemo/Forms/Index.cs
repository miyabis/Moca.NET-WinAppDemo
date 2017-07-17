using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MocaDemo
{
	public partial class Index : Form
	{

		#region Declare

		Db.IDaoDemo _dao;
		IDemoDefinition _def;
		
		#endregion

		#region コンストラクタ

		public Index()
		{
			InitializeComponent();
		}
		
		#endregion

		#region Handles

		private void Index_Load(object sender, EventArgs e)
		{
			grdFindResults.BorderStyle = BorderStyle.None;
			grdFindResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			grdFindResults.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			grdFindResults.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			grdFindResults.BackgroundColor = BackColor;
			grdFindResults.AllowUserToAddRows = false;
			grdFindResults.RowTemplate.Height = 30;

			List<DemoRow> lst = new List<DemoRow>();
			lst.Add(new DemoRow());
			DataBinder1.DataSource = lst;
			DataBinder1.DataBinding(txtID, _def.Id);
			DataBinder1.DataBinding(txtName, _def.Name);
			DataBinder1.DataBinding(txtNote, _def.Note);
			DataBinder1.Position = 0;
			DataBinder1.AcceptChanges();

			_clear();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			_search();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (!grdFindResults.HasChanges) {
						 return;
			}

			IList<DemoRow> lst = grdFindResults.GetChanges<DemoRow>();
			_dao.Mod(lst);

			_search();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtID.Text.Trim()))
			{
				return;
			}

			DemoRow value = DataBinder1.CurrentEntity<DemoRow>();
			_dao.Ins(value);

			_search();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_clear();
		}

		private void grdFindResults_GridColmnSetting(object sender, Moca.Win.GridColmnSettingEventArgs e)
		{
			switch (e.Column.Name)
			{
				case "Id":
					e.Column.ReadOnly = true;
					break;
			}
		}

		#endregion
		#region Method

		void _clear()
		{
			txtFindID.Clear();
			txtID.Clear();
			txtName.Clear();
			txtNote.Clear();
			DataBinder1.AcceptChanges();
		}

		void _search()
		{
			grdFindResults.DataSource = _dao.Get(txtFindID.Text);
		}

		#endregion

	}
}
