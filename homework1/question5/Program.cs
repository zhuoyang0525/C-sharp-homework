using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace question5
{
	public class Program : Form
	{
		TextBox txt1 = new TextBox();
		TextBox txt2 = new TextBox();
		Button btn = new Button();
		Label lbl = new Label();

		public void init()
		{
			this.Controls.Add(txt1);
			this.Controls.Add(txt2);
			this.Controls.Add(btn);
			this.Controls.Add(lbl);
			txt1.Dock = System.Windows.Forms.DockStyle.Top;
			txt2.Dock = System.Windows.Forms.DockStyle.Top;
			btn.Dock = System.Windows.Forms.DockStyle.Fill;
			lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
			btn.Text = "求乘积";
			lbl.Text = "用于显示结果的标签";
			this.Size = new Size(600, 300);

			btn.Click += new System.EventHandler(this.buttonl_Click);

		}

		public void buttonl_Click(object sender, EventArgs e)
		{
			string s = txt1.Text;
			double d = double.Parse(s);
			string m = txt2.Text;
			double n = double.Parse(m);
			double sq = d * n;
			lbl.Text = d + "和" + n + "的积是：" + sq;
		}


		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Program f = new Program();
			f.Text = "Program";
			f.init();
			Application.Run(f);
		}
	}
}