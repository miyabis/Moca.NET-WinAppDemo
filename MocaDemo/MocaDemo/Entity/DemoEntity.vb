'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.18051
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.ComponentModel

Imports Moca.Db
Imports Moca.Db.Attr


''' <summary> 
''' DemoEntity エンティティ 
''' </summary> 
''' <remarks></remarks> 
''' <history> 
''' </history> 
Public Class DemoEntity
	Implements IEditableObject

#Region " Declare "
	Private _iD As String

	Private _code As Integer

	Private _name As String

	Private _note As String
#End Region

#Region " Property "
	''' <summary> 
	''' ID (ID) Property. 
	''' </summary> 
	<Column("ID")> _
	Public Property ID() As String
		Get
			Return Me._iD
		End Get
		Set(value As String)
			Me._iD = value
		End Set
	End Property

	''' <summary> 
	''' Code (Code) Property. 
	''' </summary> 
	<Column("Code")> _
	Public Property Code() As Integer
		Get
			Return Me._code
		End Get
		Set(value As Integer)
			Me._code = value
		End Set
	End Property

	''' <summary> 
	''' Name (Name) Property. 
	''' </summary> 
	<Column("Name")> _
	Public Property Name() As String
		Get
			Return Me._name
		End Get
		Set(value As String)
			Me._name = value
		End Set
	End Property

	''' <summary> 
	''' Note (Note) Property. 
	''' </summary> 
	<Column("Note")> _
	Public Property Note() As String
		Get
			Return Me._note
		End Get
		Set(value As String)
			Me._note = value
		End Set
	End Property
#End Region

#Region " Implements IEditableObject "

	Private _backup As DemoEntity
	Private inTxn As Boolean = False


	Public Sub BeginEdit() Implements System.ComponentModel.IEditableObject.BeginEdit
		If inTxn Then
			Return
		End If

		If Me._backup Is Nothing Then
			Me._backup = Me.MemberwiseClone
		End If

		inTxn = True
	End Sub

	Public Sub CancelEdit() Implements System.ComponentModel.IEditableObject.CancelEdit
		If Not inTxn Then
			Return
		End If

		inTxn = False
		_iD = _backup.ID
		_code = _backup.Code
		_name = _backup.Name
		_note = _backup.Note
	End Sub

	Public Sub EndEdit() Implements System.ComponentModel.IEditableObject.EndEdit
		If Not inTxn Then
			Return
		End If

		inTxn = False
		_backup = Nothing
	End Sub

#End Region

End Class

#Region " Definition "
''' <summary> 
''' DemoDefinition エンティティ定義 
''' </summary> 
''' <remarks></remarks> 
''' <history> 
''' </history> 
<Table("Moca.Demo.Db", "tbDemo")> _
Public Interface IDemoDefinitionDefinition

	''' <summary> 
	''' Table (Table) Property. 
	''' </summary> 
	Property Table() As Moca.Db.DbInfoTable

	''' <summary> 
	''' ID (ID) Property. 
	''' </summary> 
	<Column("ID")> _
	Property ID() As Moca.Db.DbInfoColumn

	''' <summary> 
	''' Code (Code) Property. 
	''' </summary> 
	<Column("Code")> _
	Property Code() As Moca.Db.DbInfoColumn

	''' <summary> 
	''' Name (Name) Property. 
	''' </summary> 
	<Column("Name")> _
	Property Name() As Moca.Db.DbInfoColumn

	''' <summary> 
	''' Note (Note) Property. 
	''' </summary> 
	<Column("Note")> _
	Property Note() As Moca.Db.DbInfoColumn
End Interface
#End Region