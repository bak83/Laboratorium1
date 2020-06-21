using System;
using System.Windows.Forms;
using System.Drawing;

namespace Laboratorium1
{
	public class Greyhound	
	{
		public int StartingPosition;
		public int RacetrackLength;
		public PictureBox MyPictureBox = null;
		public int Location = 0;
		public  Random MyRandom;

		public bool Run(int distance)
		{
			//run forward 1,2,3 or 4 spaces at random
			//int distance;
			//distance = MyRandom.Next(1, 4);
			MyPictureBox.Left += distance;
			//update the postion of the my picturebox
			//Point p = MyPictureBox.Location;
			//p.X += distance;
			//MyPictureBox.Location = p;

			//return true if i won the race
			if (MyPictureBox.Left >= RacetrackLength)
				return (true);
			else
			{
				return (false);
			}
		}
		public void TakeStartingPostion()
		{
			//reset my position to the starting point
			Point p = MyPictureBox.Location;
			p.X = StartingPosition;
			MyPictureBox.Location = p;
		}

	}
}
