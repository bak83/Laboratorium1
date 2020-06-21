using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laboratorium1
{
	public class Guy
	{
		public string name;
		//pulic Bet MyBet;
		public int Cash;
		public RadioButton MyRadioButton;
		public Label MyLabel;

		public void UpdateLabels()
		{
			MyLabel.Refresh();
			if (MyRadioButton.Checked)
				MyLabel.Text = name + " postawił";
			else
				MyLabel.Text = name + " nie obstawia";
			MyLabel.Refresh();

		}

		public void ClearBet()
		{

		}
		public bool PlaceBet(int amount, int DogToWin)
		{
			return true;
		}

		public void Collect(int Winner)
		{

		}


	}
}
