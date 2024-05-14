using System;
using System.Windows.Forms;

namespace Executor
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00004881 File Offset: 0x00002A81
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Key());
		}
	}
}
