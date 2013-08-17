
Public Class Main

	Protected dao As Db.IDaoDemo

	Protected defDemo As IDemoDefinitionDefinition

	Private Sub Main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
		Me.btnUpd.Text = "Insert"
		Me.btnCancel.Visible = False
	End Sub

	Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
		_clear()
	End Sub

	Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
		Me.DataBinder2.RejectChanges()
	End Sub

	Private Sub btnUpd_Click(sender As System.Object, e As System.EventArgs) Handles btnUpd.Click
		Dim value As DemoEntity = New DemoEntity
		Try
			If Me.txtID.ReadOnly Then
				Me.DataBinder2.EndEdit()
				value = Me.DataBinder2.CurrentEntity(Of DemoEntity)()
			Else
				value.ID = Me.txtID.Text
				value.Name = Me.txtName.Text
				value.Note = Me.txtNote.Text

				_clear()

				MessageBox.Show(String.Format("Auto increment : {0}", Me.txtCode.Text))
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
		Dim lst As IList(Of DemoEntity)

		Me.txtID.ReadOnly = False
		Me.txtCode.ReadOnly = False

		If Me.txtID.Text.Length.Equals(0) And
		 Me.txtCode.Text.Length.Equals(0) Then
			lst = dao.[Get]()
			Me.txtName.Text = String.Empty
			Me.txtNote.Text = String.Empty
		ElseIf Me.txtID.Text.Length > 0 And
		 Me.txtCode.Text.Length.Equals(0) Then
			lst = dao.[Get](Me.txtID.Text)
			Me.txtName.Text = String.Empty
			Me.txtNote.Text = String.Empty
		ElseIf Me.txtID.Text.Length > 0 And
		 Me.txtCode.Text.Length > 0 Then
			lst = dao.[Get](Me.txtID.Text, Me.txtCode.Text)
			Me.txtName.Text = String.Empty
			Me.txtNote.Text = String.Empty
			Me.txtID.ReadOnly = True
			Me.txtCode.ReadOnly = True
			Me.btnUpd.Text = "Modify"
			Me.DataBinder2.DataSource = lst
			Me.DataBinder2.DataBinding(Me.txtID, defDemo.ID)
			Me.DataBinder2.DataBinding(Me.txtCode, defDemo.Code)
			Me.DataBinder2.DataBinding(Me.txtName, defDemo.Name)
			Me.DataBinder2.DataBinding(Me.txtNote, defDemo.Note)
			Me.DataBinder2.Position = 0
			Me.DataBinder2.AcceptChanges()
			Me.btnCancel.Visible = True
		Else
			lst = Nothing
		End If

		Me.dgvResults.DataSource = lst
	End Sub

	Private Sub _clear()
		Me.txtID.ReadOnly = False
		Me.txtCode.ReadOnly = False

		Me.DataBinder2.EndEdit()
		Me.txtID.DataBindings.Clear()
		Me.txtCode.DataBindings.Clear()
		Me.txtName.DataBindings.Clear()
		Me.txtNote.DataBindings.Clear()
		Me.DataBinder2.DataSource = Nothing

		Me.txtID.Text = String.Empty
		Me.txtCode.Text = String.Empty
		Me.txtName.Text = String.Empty
		Me.txtNote.Text = String.Empty

		Me.dgvResults.DataSource = Nothing

		Me.btnUpd.Text = "Insert"
		Me.btnCancel.Visible = False
	End Sub

End Class