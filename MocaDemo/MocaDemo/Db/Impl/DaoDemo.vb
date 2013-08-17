
Imports Moca.Db

Namespace Db.Impl

	''' <summary>
	''' tbMocaDemo データアクセス
	''' </summary>
	''' <remarks></remarks>
	Public Class DaoDemo
		Inherits AbstractDao
		Implements IDaoDemo

		Public Function [Get]() As System.Collections.Generic.IList(Of DemoEntity) Implements IDaoDemo.Get
			Const C_SQL As String = "SELECT [ID],[Code],[Name],[Note] FROM [tbDemo]"

			Using cmd As IDbCommandSelect = CreateCommandSelect(C_SQL)
				Return cmd.Execute(Of DemoEntity)()
			End Using
		End Function

		Public Function [Get](id As String) As System.Collections.Generic.IList(Of DemoEntity) Implements IDaoDemo.Get
			Const C_SQL As String = "SELECT [ID],[Code],[Name],[Note] FROM [tbDemo] WHERE [ID]=@ID"

			Using cmd As IDbCommandSelect = CreateCommandSelect(C_SQL)
				cmd.SetParameter("ID", id)

				Return cmd.Execute(Of DemoEntity)()
			End Using
		End Function

		Public Function [Get](id As String, code As Integer) As System.Collections.Generic.IList(Of DemoEntity) Implements IDaoDemo.Get
			Const C_SQL As String = "IDaoDemo_Get"

			Using cmd As IDbCommandStoredProcedure = CreateCommandStoredProcedure(C_SQL)
				cmd.AddParameterValue(id)
				cmd.AddParameterValue(code)

				Return cmd.Execute(Of DemoEntity)()
			End Using
		End Function

		Public Function Ins(value As DemoEntity) As Integer Implements IDaoDemo.Ins
			Const C_SQL As String = "IDaoDemo_Ins"

			Using cmd As IDbCommandStoredProcedure = CreateCommandStoredProcedure(C_SQL)
				cmd.AddParameterValue(value.ID)
				cmd.AddParameterValue(value.Name)
				cmd.AddParameterValue(value.Note)

				cmd.ExecuteNonQuery()

				Return cmd.ResultOutParameter("MaxCode")
			End Using
		End Function

	End Class

End Namespace
