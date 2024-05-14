using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Hovac_API;

namespace Executor
{
	// Token: 0x02000005 RID: 5
	public partial class Options : Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003FEA File Offset: 0x000021EA
		public Options()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000400D File Offset: 0x0000220D
		private void Options_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004010 File Offset: 0x00002210
		private void button1_Click(object sender, EventArgs e)
		{
			Process[] roblox = Process.GetProcesses();
			foreach (Process openedroblox in roblox)
			{
				bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";
				bool flag2 = flag;
				if (flag2)
				{
					openedroblox.Kill();
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004060 File Offset: 0x00002260
		private void button2_Click(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/pQF6rXMm");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004090 File Offset: 0x00002290
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/SiqScdtW");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000040BD File Offset: 0x000022BD
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/FUawEyXH5K");
		}

		// Token: 0x0400001F RID: 31
		private ExploitAPI module = new ExploitAPI();
	}
}
