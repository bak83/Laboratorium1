using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1
{
	public class Bet
	{
		public int amount;
		public int dog;
		public Guy Bettor;

		public string GetDescription ()
		{
			return "x";
		}

		public int PayOut(int Winner)
		{
			return Winner;
		}
	}
}
