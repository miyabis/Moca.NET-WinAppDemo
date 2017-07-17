//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using Moca.Db;
using Moca.Db.Attr;
using System.ComponentModel;
using Moca.Win;
using System.Windows.Forms;



///  <summary> 
///  DemoRow Entity 
///  </summary> 
///  <remarks></remarks> 
///  <history> 
///  </history> 
public class DemoRow : Moca.Win.RowModelBase, System.ComponentModel.INotifyPropertyChanged
{

	#region  Declare
	static IDemoDefinition _def;

	private string _id;

	private int _code;

	private string _name;

	private string _note;
	#endregion

	#region  Property
	///  <summary> 
	///  Id (ID) Property. 
	///  </summary> 
	[Column("ID")]
	[DisplayName("ＩＤ")]
	[ColumnStyle(50, nullValue: "")]
	[AllowMerging()]
	[Frozen()]
	public string Id
	{
		get
		{
			return this._id;
		}
		set
		{
			this._id = value;
			OnPropertyChanged("Id");
		}
	}

	///  <summary> 
	///  Code (Code) Property. 
	///  </summary> 
	[Column("Code")]
	[DisplayName("追番")]
	[ColumnStyle(50, DataGridViewContentAlignment.MiddleRight, nullValue: "")]
	[ReadOnly(true)]
	public int Code
	{
		get
		{
			return this._code;
		}
		set
		{
			this._code = value;
			OnPropertyChanged("Code");
		}
	}

	///  <summary> 
	///  Name (Name) Property. 
	///  </summary> 
	[Column("Name")]
	[DisplayName("名称")]
	[ColumnStyle(100, imeMode: ImeMode.Hiragana, nullValue: "")]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			this._name = value;
			OnPropertyChanged("Name");
		}
	}

	///  <summary> 
	///  Note (Note) Property. 
	///  </summary> 
	[Column("Note")]
	[DisplayName("備考")]
	[ColumnStyle(100, imeMode: ImeMode.Hiragana, nullValue: "")]
	public string Note
	{
		get
		{
			return this._note;
		}
		set
		{
			this._note = value;
			OnPropertyChanged("Note");
		}
	}
	#endregion

	#region  PropertyChanged
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string name)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(name));
		}
	}
	#endregion

}

#region  Definition
///  <summary> 
///  Demo Entity definition 
///  </summary> 
///  <remarks></remarks> 
///  <history> 
///  </history> 
[Table(MocaDemo.Sys.Settings.ConnectionStrings, "tbDemo")]
public interface IDemoDefinition
{

	///  <summary> 
	///  Id (ID) Property. 
	///  </summary> 
	[Column("ID")]
	Moca.Db.DbInfoColumn Id
	{
		get;
		set;
	}

	///  <summary> 
	///  Code (Code) Property. 
	///  </summary> 
	[Column("Code")]
	Moca.Db.DbInfoColumn Code
	{
		get;
		set;
	}

	///  <summary> 
	///  Name (Name) Property. 
	///  </summary> 
	[Column("Name")]
	Moca.Db.DbInfoColumn Name
	{
		get;
		set;
	}

	///  <summary> 
	///  Note (Note) Property. 
	///  </summary> 
	[Column("Note")]
	Moca.Db.DbInfoColumn Note
	{
		get;
		set;
	}
}
#endregion
