
Imports Moca.Db.Attr

Namespace Db

	''' <summary>
	''' tbMocaDemo データアクセスインタフェース
	''' </summary>
	''' <remarks></remarks>
	<Dao("Moca.Demo.Db", GetType(Impl.DaoDemo))> _
 Public Interface IDaoDemo

		Function [Get]() As IList(Of DemoEntity)

		Function [Get](ByVal id As String) As IList(Of DemoEntity)

		Function [Get](ByVal id As String, ByVal code As Integer) As IList(Of DemoEntity)

		<Transaction()>
		Function Ins(ByVal value As DemoEntity) As Integer

	End Interface

End Namespace
