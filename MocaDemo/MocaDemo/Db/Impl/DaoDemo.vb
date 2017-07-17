
Imports Moca.Db

Namespace Db.Impl

	''' <summary>
	''' tbMocaDemo データアクセス
	''' </summary>
	''' <remarks></remarks>
	Public Class DaoDemo
		Inherits AbstractDao
		Implements IDaoDemo

		Public Function [Get](id As String) As System.Collections.Generic.IList(Of DemoRow) Implements IDaoDemo.Get
			Const sql As String = "SELECT [ID],[Code],[Name],[Note] FROM [tbDemo] WHERE @ID IS NULL OR (@ID IS NOT NULL AND [ID] LIKE '%' + @ID + '%')"

			Using cmd As IDbCommandSelect = CreateCommandSelect(sql)
				cmd.SetParameter("ID", CNothing(id))

				Return cmd.Execute(Of DemoRow)()
			End Using
		End Function

		Public Function [Get](id As String, code As Integer) As System.Collections.Generic.IList(Of DemoRow) Implements IDaoDemo.Get
			Const sql As String = "IDaoDemo_Get"

			Using cmd As IDbCommandStoredProcedure = CreateCommandStoredProcedure(sql)
				cmd.AddParameterValue(id)
				cmd.AddParameterValue(code)

				Return cmd.Execute(Of DemoRow)()
			End Using
		End Function

		Public Function Ins(value As DemoRow) As Integer Implements IDaoDemo.Ins
			Const sql As String = "IDaoDemo_Ins"

			Using cmd As IDbCommandStoredProcedure = CreateCommandStoredProcedure(sql)
				cmd.AddParameterValue(value.ID)
				cmd.AddParameterValue(value.Name)
				cmd.AddParameterValue(value.Note)

				Dim cnt As Integer
				cnt = cmd.ExecuteNonQuery()
				If cnt.Equals(0) Then
					Return 0
				End If

				Return cmd.ResultOutParameter("MaxCode")
			End Using
		End Function

		Public Sub [Mod](lst As IList(Of DemoRow)) Implements IDaoDemo.Mod
			Const sql As String = "UPDATE [tbDemo] SET [Name] = @Name ,[Note] = @Note WHERE [ID] = @ID AND [Code] = @Code"

			Using cmd As IDbCommandUpdate = CreateCommandUpdate(sql)
				cmd.Prepare()

				For Each row As DemoRow In lst
					cmd.SetParameter("Name", row.Name)
					cmd.SetParameter("Note", row.Note)
					cmd.SetParameter("ID", row.Id)
					cmd.SetParameter("Code", row.Code)

					Dim rc As Integer
					rc = cmd.Execute()
				Next
			End Using
		End Sub

	End Class

End Namespace
