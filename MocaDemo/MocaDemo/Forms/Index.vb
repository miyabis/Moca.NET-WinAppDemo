
Public Class Index

#Region " Declare "

	Private _dao As Db.IDaoDemo
	Private _def As IDemoDefinition

#End Region

#Region " Handles "

	Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		grdFindResults.BorderStyle = BorderStyle.None
		grdFindResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
		grdFindResults.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
		grdFindResults.CellBorderStyle = DataGridViewCellBorderStyle.Single
		grdFindResults.BackgroundColor = Me.BackColor
		grdFindResults.AllowUserToAddRows = False
		grdFindResults.RowTemplate.Height = 30

		Dim lst As New List(Of DemoRow)
		lst.Add(New DemoRow)
		DataBinder1.DataSource = lst
		DataBinder1.DataBinding(Me.txtID, _def.Id)
		DataBinder1.DataBinding(Me.txtName, _def.Name)
		DataBinder1.DataBinding(Me.txtNote, _def.Note)
		DataBinder1.Position = 0
		DataBinder1.AcceptChanges()

		_clear()
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		_search()
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		If Not grdFindResults.HasChanges Then
			Return
		End If

		Dim lst As IList(Of DemoRow) = grdFindResults.GetChanges(Of DemoRow)()
		_dao.Mod(lst)

		_search()
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		If String.IsNullOrEmpty(txtID.Text.Trim) Then
			Return
		End If

		Dim value As DemoRow = DataBinder1.CurrentEntity(Of DemoRow)()
		_dao.Ins(value)

		_search()
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		_clear()
	End Sub

	Private Sub grdFindResults_GridColmnSetting(sender As Object, e As Moca.Win.GridColmnSettingEventArgs) Handles grdFindResults.GridColmnSetting
		Select Case e.Column.Name
			Case "Id"
				e.Column.ReadOnly = True
		End Select
	End Sub

#End Region
#Region " Method "

	Private Sub _clear()
		txtFindID.Clear()
		txtID.Clear()
		txtName.Clear()
		txtNote.Clear()
		DataBinder1.AcceptChanges()
	End Sub

	Private Sub _search()
		grdFindResults.DataSource = _dao.Get(txtFindID.Text)
	End Sub

#End Region

End Class
