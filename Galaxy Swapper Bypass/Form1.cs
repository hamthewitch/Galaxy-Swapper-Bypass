using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Galaxy_Swapper_Bypass.Properties;

namespace Galaxy_Swapper_Bypass
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002073 File Offset: 0x00000273
		private void Close_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207D File Offset: 0x0000027D
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.galaxyswapperv2.com/KeySystem/CreateKey.php");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000208B File Offset: 0x0000028B
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.galaxyswapperv2.com/Downloads/v2/Galaxy%20Swapper%20v2.zip");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002099 File Offset: 0x00000299
		private void Beuh_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B4 File Offset: 0x000002B4
		private void Beuh_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			bool flag2 = flag;
			if (flag2)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x04000001 RID: 1
		private Point lastPoint;
	}
}
