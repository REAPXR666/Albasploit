using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Hovac_API;

namespace Executor
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002073 File Offset: 0x00000273
		private void button2_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002082 File Offset: 0x00000282
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002085 File Offset: 0x00000285
		private void button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002088 File Offset: 0x00000288
		private void button4_Click(object sender, EventArgs e)
		{
			ScriptHub openform = new ScriptHub();
			openform.Show();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		private void button10_Click(object sender, EventArgs e)
		{
			Options openform = new Options();
			openform.Show();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020BF File Offset: 0x000002BF
		private void button1_Click(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.module.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020E1 File Offset: 0x000002E1
		private void button6_Click_1(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020F0 File Offset: 0x000002F0
		private void button5_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter sw = new StreamWriter(s))
					{
						sw.Write(this.fastColoredTextBox1.Text);
					}
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002180 File Offset: 0x00000380
		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files|*.txt";
			openFileDialog.Title = "Open";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021D2 File Offset: 0x000003D2
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021EC File Offset: 0x000003EC
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000224D File Offset: 0x0000044D
		private void button7_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002256 File Offset: 0x00000456
		private void button9_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002261 File Offset: 0x00000461
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000227C File Offset: 0x0000047C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022E0 File Offset: 0x000004E0
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002341 File Offset: 0x00000541
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000235B File Offset: 0x0000055B
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002378 File Offset: 0x00000578
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023D9 File Offset: 0x000005D9
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/FUawEyXH5K");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023E7 File Offset: 0x000005E7
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023EA File Offset: 0x000005EA
		private void button11_Click(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023F5 File Offset: 0x000005F5
		private void button11_Click_1(object sender, EventArgs e)
		{
			base.TopMost = !base.TopMost;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002408 File Offset: 0x00000608
		private void button12_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Albaware/AlbaSploit");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002416 File Offset: 0x00000616
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002419 File Offset: 0x00000619
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000241C File Offset: 0x0000061C
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI module = new ExploitAPI();

		// Token: 0x04000002 RID: 2
		private Point lastPoint;
	}
}
