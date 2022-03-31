/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/19/2022
 * Time: 8:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KalkulatorSederhana
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtntambahClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong!");
			}
			else
			{
				//Ini untuk Tambah
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a + b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		
		void BtnkurangClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong!");
			}
			else
			{
				//Ini untuk Kurang
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a - b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		void BtnkaliClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong!");
			}
			else
			{
				//Ini untuk Kali
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a * b;
				this.LBLHasil.Text = c.ToString();
			}	
		}
		void BtnbersihkanClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			LBLHasil.Text = "";
		}
		
		void LBLHasilClick(object sender, EventArgs e)
		{
	
		}

		void BtnbagiClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong!");
			}
			else
			{
				//Ini untuk Bagi
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a/b;
				this.LBLHasil.Text = c.ToString();	
			}
		}
	}
}
