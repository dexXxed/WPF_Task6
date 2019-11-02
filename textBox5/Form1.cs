using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace textBox5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox3.Text != "" && textBox2.Text != "")
			{
				StreamWriter write_text;
				FileInfo file = new FileInfo(textBox3.Text);
				write_text = file.AppendText();
				write_text.WriteLine(textBox2.Text);
				write_text.Close();
				MessageBox.Show("Ваш текст записан в файл " + textBox3.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Заполните два текстовых окна!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

	}
}
