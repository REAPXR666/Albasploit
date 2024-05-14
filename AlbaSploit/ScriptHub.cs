using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Hovac_API;

namespace Executor
{
	// Token: 0x02000007 RID: 7
	public partial class ScriptHub : Form
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000489C File Offset: 0x00002A9C
		public ScriptHub()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000048C0 File Offset: 0x00002AC0
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/DRMbD8bk");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000048ED File Offset: 0x00002AED
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000048F0 File Offset: 0x00002AF0
		private void button10_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000048FC File Offset: 0x00002AFC
		private void ScriptHub_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000495D File Offset: 0x00002B5D
		private void ScriptHub_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004977 File Offset: 0x00002B77
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004994 File Offset: 0x00002B94
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000049F5 File Offset: 0x00002BF5
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004A10 File Offset: 0x00002C10
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004A71 File Offset: 0x00002C71
		private void button9_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004A7C File Offset: 0x00002C7C
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/JcSpxu0a");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004AAC File Offset: 0x00002CAC
		private void button5_Click_1(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/35FrqXhb");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004ADC File Offset: 0x00002CDC
		private void button7_Click(object sender, EventArgs e)
		{
			WebClient wb = new WebClient();
			string Script = wb.DownloadString("https://pastebin.com/raw/2QDkKn7k");
			this.module.SendLuaScript(Script);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004B09 File Offset: 0x00002D09
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/FUawEyXH5K");
		}

		// Token: 0x04000029 RID: 41
		private ExploitAPI module = new ExploitAPI();

		// Token: 0x0400002A RID: 42
		private Point lastPoint;
	}
}
