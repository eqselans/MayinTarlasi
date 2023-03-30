using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AynıZamanlıUretim
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblSkor.Text = "0";
			lblMayın.Text = "3";
		}

		private void btnUret_Click(object sender, EventArgs e)
		{
			int bomb1;
			int bomb2;
			int bomb3;

			Random rnd = new Random();

			bomb1 = rnd.Next(1,60);
			bomb2 = rnd.Next(1,60);
			bomb3 = rnd.Next(1,60);




			for(int i =1;i<=60;i++)
			{
				Button btnTemp = new Button();

				btnTemp.Name = "btn"+i.ToString();
				btnTemp.Size = new System.Drawing.Size(35, 35);
				btnTemp.TabIndex = 0;
				btnTemp.UseVisualStyleBackColor = true;

				if (bomb1 == i || bomb2 == i || bomb3 == i)
				{
					btnTemp.Tag = true;
				}
				else
				{
					btnTemp.Tag = false;
				}
				btnTemp.Click += BtnTemp_Click;
				flowLayoutPanel1.Controls.Add(btnTemp);
			}
		}

		
		private void BtnTemp_Click(object sender, EventArgs e)
		{
			Button basilanButton = (Button)sender;
			bool mayınBulunduMu = (bool)basilanButton.Tag;

			if (mayınBulunduMu)
			{
				MessageBox.Show("Mayını bulundu!!!","UYARI");
				basilanButton.BackgroundImage = Image.FromFile("bomb1.png");

				

				int mayın = int.Parse(lblMayın.Text);
				mayın--;
				lblMayın.Text = mayın.ToString();
				int skor = int.Parse(lblSkor.Text);
				skor-=10;
				lblSkor.Text = skor.ToString();



				if (mayın == 0)
				{
					MessageBox.Show("OYUN BİTTİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					this.Close();
				}
			}
			else
			{
				basilanButton.BackColor = Color.Green;

				int skor = int.Parse(lblSkor.Text);
				skor++;
				lblSkor.Text = skor.ToString();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
