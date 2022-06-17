namespace Galaxy_Swapper_Bypass
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002118 File Offset: 0x00000318
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002150 File Offset: 0x00000350
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Galaxy_Swapper_Bypass.Form1));
			this.Beuh = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Close = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.Beuh.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Close).BeginInit();
			base.SuspendLayout();
			this.Beuh.BackColor = global::System.Drawing.Color.FromArgb(28, 31, 46);
			this.Beuh.Controls.Add(this.pictureBox1);
			this.Beuh.Controls.Add(this.Close);
			this.Beuh.Location = new global::System.Drawing.Point(0, 0);
			this.Beuh.Name = "Beuh";
			this.Beuh.Size = new global::System.Drawing.Size(510, 32);
			this.Beuh.TabIndex = 11;
			this.Beuh.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Beuh_MouseDown);
			this.Beuh.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Beuh_MouseMove);
			this.pictureBox1.Image = global::Galaxy_Swapper_Bypass.Properties.Resources.subtract_26px;
			this.pictureBox1.Location = new global::System.Drawing.Point(447, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(27, 29);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.Close.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Close.Image = global::Galaxy_Swapper_Bypass.Properties.Resources.multiply_26px;
			this.Close.Location = new global::System.Drawing.Point(480, 3);
			this.Close.Name = "Close";
			this.Close.Size = new global::System.Drawing.Size(27, 29);
			this.Close.TabIndex = 2;
			this.Close.TabStop = false;
			this.Close.Click += new global::System.EventHandler(this.Close_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Bebas Neue", 21.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(210, 135);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(82, 35);
			this.label2.TabIndex = 13;
			this.label2.Text = "Bypass";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bebas Neue", 48f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new global::System.Drawing.Point(68, 73);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(377, 77);
			this.label1.TabIndex = 12;
			this.label1.Text = "Galaxy Swapper";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(28, 31, 46);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new global::System.Drawing.Point(259, 210);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(237, 72);
			this.button2.TabIndex = 10;
			this.button2.Text = "Get key";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 31, 46);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new global::System.Drawing.Point(11, 210);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(237, 72);
			this.button1.TabIndex = 9;
			this.button1.Text = "Galaxy Swapper Download";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(22, 26, 37);
			base.ClientSize = new global::System.Drawing.Size(509, 304);
			base.Controls.Add(this.Beuh);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Form1";
			this.Beuh.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Close).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel Beuh;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000005 RID: 5
		private new global::System.Windows.Forms.PictureBox Close;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button button1;
	}
}
