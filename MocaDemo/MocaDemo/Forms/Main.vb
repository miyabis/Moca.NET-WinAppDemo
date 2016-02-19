
Public Class Main

	Protected dao As Db.IDaoDemo

	Protected defDemo As IDemoDefinitionDefinition

	Private Sub Main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
		Me.btnUpd.Text = "Insert"
		Me.btnCancel.Visible = False
		Me.txtCode.ReadOnly = True
	End Sub

	Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
		_clear()
	End Sub

	Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DataBinder1.RejectChanges()
    End Sub

    Private Sub btnUpd_Click(sender As System.Object, e As System.EventArgs) Handles btnUpd.Click
        Dim value As DemoEntity = New DemoEntity
        Try
            If Me.txtID.ReadOnly Then
                Me.DataBinder1.EndEdit()
                value = Me.DataBinder1.CurrentEntity(Of DemoEntity)()

                dao.Mod(value)
            Else
                value.ID = Me.txtID.Text
                value.Name = Me.txtName.Text
                value.Note = Me.txtNote.Text

                Me.txtCode.Text = dao.Ins(value)

                MessageBox.Show(String.Format("Auto increment : {0}", Me.txtCode.Text))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            _clear()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim lst As IList(Of DemoEntity)

        _clear()

        If Me.txtSearchID.Text.Length.Equals(0) And
         Me.txtSearchCode.Text.Length.Equals(0) Then
            lst = dao.[Get]()
        ElseIf Me.txtSearchID.Text.Length > 0 And
         Me.txtSearchCode.Text.Length.Equals(0) Then
            lst = dao.[Get](Me.txtSearchID.Text)
        ElseIf Me.txtSearchID.Text.Length > 0 And
         Me.txtSearchCode.Text.Length > 0 Then
            lst = dao.[Get](Me.txtSearchID.Text, Me.txtSearchCode.Text)
        Else
            lst = Nothing
            Return
        End If

        Me.DataBinder1.DataSource = lst

        Me.txtID.ReadOnly = True
        Me.btnUpd.Text = "Modify"
        Me.DataBinder1.DataBinding(Me.txtID, defDemo.ID)
        Me.DataBinder1.DataBinding(Me.txtCode, defDemo.Code)
        Me.DataBinder1.DataBinding(Me.txtName, defDemo.Name)
        Me.DataBinder1.DataBinding(Me.txtNote, defDemo.Note)
        Me.DataBinder1.Position = 0
        Me.DataBinder1.AcceptChanges()
        Me.btnCancel.Visible = True

        Me.dgvResults.DataSource = Me.DataBinder1.BindSrc
    End Sub

    Private Sub _clear()
        Me.txtSearchID.Text = String.Empty
        Me.txtSearchCode.Text = String.Empty

        Me.txtID.ReadOnly = False

        Me.DataBinder1.EndEdit()
        Me.txtID.DataBindings.Clear()
        Me.txtCode.DataBindings.Clear()
        Me.txtName.DataBindings.Clear()
        Me.txtNote.DataBindings.Clear()
        Me.DataBinder1.DataSource = Nothing
        Me.dgvResults.ClearSelection()

		Me.txtID.Text = String.Empty
		Me.txtCode.Text = String.Empty
		Me.txtName.Text = String.Empty
		Me.txtNote.Text = String.Empty

		Me.dgvResults.DataSource = Nothing

		Me.btnUpd.Text = "Insert"
		Me.btnCancel.Visible = False
	End Sub

End Class