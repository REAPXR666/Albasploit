using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Executor
{
	// Token: 0x02000004 RID: 4
	public partial class Key : Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003551 File Offset: 0x00001751
		public Key()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000356C File Offset: 0x0000176C
		private void button1_Click(object sender, EventArgs e)
		{
			string gettext = this.textBox1.Text;
			int gettext_amount = gettext.Length;
			bool flag = gettext_amount > 29;
			if (flag)
			{
				WebClient wc = new WebClient();
				string ks = wc.DownloadString("https://services.albaware.org/albasploitkey");
				bool flag2 = ks.Contains(this.textBox1.Text);
				if (flag2)
				{
					base.Hide();
					Form1 mainui = new Form1();
					mainui.Show();
				}
				else
				{
					MessageBox.Show("Invalid key!", "AlbaSploit");
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000035EF File Offset: 0x000017EF
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://link-hub.net/912585/albasploit");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000035FD File Offset: 0x000017FD
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/FUawEyXH5K");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000360B File Offset: 0x0000180B
		private void Key_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003610 File Offset: 0x00001810
		private void Key_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003671 File Offset: 0x00001871
		private void Key_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000368B File Offset: 0x0000188B
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000036A8 File Offset: 0x000018A8
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003709 File Offset: 0x00001909
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000370C File Offset: 0x0000190C
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000376D File Offset: 0x0000196D
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003787 File Offset: 0x00001987
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000037A4 File Offset: 0x000019A4
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003805 File Offset: 0x00001A05
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000015 RID: 21
		private Point lastPoint;
	}
}
