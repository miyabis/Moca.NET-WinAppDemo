using System;
using System.Windows.Forms;
using Moca.Di;

namespace MocaDemo
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			// 暗号化
			Moca.Configuration.SectionProtector.Protect();
			MocaContainerFactory.Init();	// Moca初期化

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Index());

			MocaContainerFactory.Destroy();	// Moca終了
		}
	}
}
