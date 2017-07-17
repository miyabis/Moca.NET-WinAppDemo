using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Moca.Db;

namespace MocaDemo.Db.Impl
{
	/// <summary>
	/// DaoClass データアクセス
	/// </summary>
	class DaoDemo : AbstractDao, IDaoDemo
	{

		public IList<DemoRow> Get(string id)
		{
			const string sql = "SELECT [ID],[Code],[Name],[Note] FROM [tbDemo] WHERE @ID IS NULL OR (@ID IS NOT NULL AND [ID] LIKE '%' + @ID + '%')";
			using (IDbCommandSelect cmd = CreateCommandSelect(sql))
			{
				cmd.SetParameter("ID", CNothing(id));

				return cmd.Execute<DemoRow>();
			}
		}

		public IList<DemoRow> Get(string id, int code)
		{
			
			const string sql = "IDaoDemo_Get";
			using (IDbCommandStoredProcedure cmd = CreateCommandStoredProcedure(sql))
			{
				cmd.AddParameterValue(id);
				cmd.AddParameterValue(code);

				return cmd.Execute<DemoRow>();
			}

		}

		public int Ins(DemoRow value)
		{
			
			const string sql = "IDaoDemo_Ins";
			using (IDbCommandStoredProcedure cmd = CreateCommandStoredProcedure(sql))
			{
				cmd.AddParameterValue(value.Id);
				cmd.AddParameterValue(value.Name);
				cmd.AddParameterValue(value.Note);

				int cnt;
				cnt = cmd.ExecuteNonQuery();
				if (cnt.Equals(0))
				{
					return 0;
				}
				return (int)cmd.ResultOutParameter["MaxCode"];
			}

		}

		public void Mod(IList<DemoRow> lst)
		{
			
			const string sql = "UPDATE [tbDemo] SET [Name] = @Name ,[Note] = @Note WHERE [ID] = @ID AND [Code] = @Code";
			using (IDbCommandUpdate cmd = CreateCommandUpdate(sql))
			{
				cmd.Prepare();

				foreach (DemoRow row in lst)
				{
					cmd.SetParameter("Name", row.Name);
					cmd.SetParameter("Note", row.Note);
					cmd.SetParameter("ID", row.Id);
					cmd.SetParameter("Code", row.Code);

					int cnt;
					cnt = cmd.Execute();
				}
			}

		}

	}
}
