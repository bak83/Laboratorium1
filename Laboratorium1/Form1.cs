using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium1
{
	public partial class Form1 : Form
	{
		Greyhound[] GreyhoundArray = new Greyhound[4];
		Guy[] GuyArray = new Guy[3];
		

		public Form1()
		{
			InitializeComponent();
			setupRaceTrack();
		}


		private void setupRaceTrack()
		{
			GreyhoundArray[0] = new Greyhound() { MyPictureBox = pictureBox2, StartingPosition = pictureBox2.Left, RacetrackLength = pictureBox1.Width - pictureBox2.Width,MyRandom = new Random() };
			GreyhoundArray[1] = new Greyhound() { MyPictureBox = pictureBox3, StartingPosition = pictureBox3.Left, RacetrackLength = pictureBox1.Width - pictureBox3.Width, MyRandom = new Random() };
			GreyhoundArray[2] = new Greyhound() { MyPictureBox = pictureBox4, StartingPosition = pictureBox4.Left, RacetrackLength = pictureBox1.Width - pictureBox4.Width };
			GreyhoundArray[3] = new Greyhound() { MyPictureBox = pictureBox5, StartingPosition = pictureBox5.Left, RacetrackLength = pictureBox1.Width - pictureBox5.Width };
			GuyArray[0] = new Guy { Cash = 45, MyLabel = label3,name = "joe",MyRadioButton = radioButton1 };
			GuyArray[1] = new Guy { Cash = 45, MyLabel = label4, name = "bob", MyRadioButton = radioButton2 };
			GuyArray[2] = new Guy { Cash = 45, MyLabel = label5, name = "all", MyRadioButton = radioButton3 };


			//Greyhound.MyRandom = new Random();







		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{

				GuyArray[0].UpdateLabels();
				GuyArray[1].UpdateLabels();
				GuyArray[2].UpdateLabels();


				if (GreyhoundArray[0].MyPictureBox.Left >= GreyhoundArray[0].RacetrackLength)
				{
					MessageBox.Show("Koniec");
					return;
				}
				GreyhoundArray[0].Run(1);
				GreyhoundArray[0].Run(GreyhoundArray[0].MyRandom.Next(1, 4));
				GreyhoundArray[0].Run(GreyhoundArray[0].MyRandom.Next(1, 4));

				if (GreyhoundArray[1].MyPictureBox.Left >= GreyhoundArray[1].RacetrackLength)
					return;
				GreyhoundArray[1].Run(2);
				GreyhoundArray[1].Run(GreyhoundArray[1].MyRandom.Next(1, 4));
				GreyhoundArray[1].Run(GreyhoundArray[1].MyRandom.Next(1, 4));

			}
		}

	
	}
}
