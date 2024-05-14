namespace Executor
{
	// Token: 0x02000005 RID: 5
	public partial class Options : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000040CC File Offset: 0x000022CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004104 File Offset: 0x00002304
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Executor.Options));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(612, 48);
			this.panel1.TabIndex = 9;
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(58, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(39, 38);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(13, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(39, 38);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(253, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(133, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "AlbaSploit";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(13, 54);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(191, 91);
			this.button1.TabIndex = 10;
			this.button1.Text = "Close Roblox";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(12, 151);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(191, 91);
			this.button2.TabIndex = 11;
			this.button2.Text = "Anti-AFK";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(13, 248);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(191, 91);
			this.button3.TabIndex = 12;
			this.button3.Text = "Force-Reset";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button4.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(13, 347);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(191, 91);
			this.button4.TabIndex = 13;
			this.button4.Text = "Coming Soon";
			this.button4.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new global::System.Drawing.Size(613, 450);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			this.ForeColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Options";
			this.Text = "AlbaSploit - Options";
			base.Load += new global::System.EventHandler(this.Options_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000020 RID: 32
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
