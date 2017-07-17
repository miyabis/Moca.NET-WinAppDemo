
Imports Moca.Attr
Imports Moca.Db.Attr

Namespace Db

    ''' <summary>
    ''' tbMocaDemo データアクセスインタフェース
    ''' </summary>
    ''' <remarks></remarks>
    <Dao(Sys.C_CONNECTION_STRING, GetType(Impl.DaoDemo))>
    Public Interface IDaoDemo

		''' <summary>
		''' SELECT の文字列を実行するサンプル
		''' </summary>
		''' <param name="id"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Function [Get](ByVal id As String) As IList(Of DemoRow)

		''' <summary>
		''' SELECT のストアドを実行するサンプル
		''' </summary>
		''' <param name="id"></param>
		''' <param name="code"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Function [Get](ByVal id As String, ByVal code As Integer) As IList(Of DemoRow)

		''' <summary>
		''' 更新系のストアドを実行するサンプル
		''' </summary>
		''' <param name="value"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		<Transaction()>
		<Aspect(GetType(SQLStatementlogger))>
		Function Ins(ByVal value As DemoRow) As Integer

		''' <summary>
		''' 更新系の文字列を実行するサンプル
		''' </summary>
		''' <param name="lst"></param>
		''' <remarks></remarks>
		<Transaction()>
		Sub [Mod](ByVal lst As IList(Of DemoRow))

    End Interface

End Namespace
