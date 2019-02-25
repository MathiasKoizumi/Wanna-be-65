using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		private Bongo jiggy;

		public Form1 form1
		{
			get;
			set;
		}

		public BolleHeaven(Form1 form)
		{
			form1 = form;
			jiggy = new Bongo(form1);
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		public string vowel(int joy, Random jiggo)
		{
			string[] array = callShuffle(new string[11]
			{
				"a",
				"e",
				"ole",
				"i",
				"y",
				"iv",
				"af",
				" ",
				"up",
				"ed",
				"an"
			});
			return array[jiggo.Next(11)];
		}

		public string constantIteration(int numberJoy, Random joy)
		{
			string[] array = callShuffle(new string[15]
			{
				"j",
				"k",
				"t",
				"s",
				"r",
				"v",
				" ",
				"n",
				"m",
				"p",
				"-",
				"\u00b4",
				"|",
				"3",
				"-4"
			});
			return array[joy.Next(15)];
		}

		private string[] callShuffle(string[] bonnysFornøjelse)
		{
			return bonnysFornøjelse;
		}

		public string gEn2Name(int lenght, Random pig)
		{
			switch (pig.Next(8))
			{
			case 0:
				return constantIteration(133, pig) + vowel(12, pig) + constantIteration(150, pig) + vowel(1400, pig) + constantIteration(132, pig);
			case 1:
				return vowel(21, pig) + constantIteration(951, pig) + constantIteration(391, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 2:
				return constantIteration(124, pig) + constantIteration(135, pig) + vowel(146, pig) + vowel(61, pig) + constantIteration(13, pig);
			case 3:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig);
			case 4:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(153, pig) + constantIteration(561, pig);
			case 5:
				return vowel(153, pig) + constantIteration(186, pig) + constantIteration(55, pig) + vowel(153, pig) + constantIteration(561, pig) + vowel(351, pig) + constantIteration(561, pig) + constantIteration(561, new Random(4000));
			case 6:
				return vowel(351, pig) + constantIteration(186, pig) + vowel(153, pig) + vowel(351, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + constantIteration(186, pig) + constantIteration(186, pig);
			default:
				return vowel(654, pig) + constantIteration(364, pig) + vowel(136, pig) + constantIteration(153, pig) + constantIteration(153, pig);
			}
		}

		internal static Jongo bongo(int p, Afmagt afmagt)
		{
			throw new NotImplementedException();
		}
	}
}
