using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moca.Db.Attr;
using Moca.Attr;

namespace MocaDemo.Db
{
	/// <summary>
	/// DaoClass1 データアクセスインタフェース
	/// </summary>
	[Dao(MocaDemo.Sys.Settings.ConnectionStrings, typeof(Impl.DaoDemo))]
	public interface IDaoDemo
	{

		/// <summary>
		/// SELECT の文字列を実行するサンプル
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IList<DemoRow> Get(string id);

		/// <summary>
		/// SELECT のストアドを実行するサンプル
		/// </summary>
		/// <param name="id"></param>
		/// <param name="code"></param>
		/// <returns></returns>
		IList<DemoRow> Get(string id, int code);

		/// <summary>
		/// 更新系のストアドを実行するサンプル
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Transaction()]
		int Ins(DemoRow value);

		/// <summary>
		/// 更新系の文字列を実行するサンプル
		/// </summary>
		/// <param name="lst"></param>
		[Transaction()]
		void Mod(IList<DemoRow> lst);

	}
}
