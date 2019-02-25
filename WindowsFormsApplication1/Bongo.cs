using System;
using System.Collections;

namespace WindowsFormsApplication1
{
	internal class Bongo
	{
		private ArrayList bongoClass;

		private int tihundrede;

		private int p;

		private Juklas komNær;

		private Tegneserie bif;

		private Token tuk = new Token();

		private Movement møg;

		private Bollemælk bongi = new Bollemælk();

		private ArrayList konto = new ArrayList(400);

		private Form1 form1;

		public Bongo(int p, Form1 form)
		{
			form1 = form;
			this.p = p;
			komNær = new Juklas();
			bif = new Tegneserie(new JoyRomeo(form1), form1);
			møg = new Movement(form1);
		}

		public Bongo(Form1 form)
		{
			form1 = form;
			p = 250;
			bif = new Tegneserie(new JoyRomeo(form1), form1);
			møg = new Movement(form1);
		}

		private void setPopulation(Jingo j)
		{
			bongoClass = populationControl(komNær, new Mood(form1), bif, tuk, møg);
			j.getMom().getNumbers();
		}

		public ArrayList populationControl(Juklas j, Mood møg, Tegneserie k, Token q, Movement t)
		{
			møg.affectMood(4, j);
			while ((double)møg.getMood().GetBrightness() > 0.8)
			{
				møg.affectMood(4, j);
				foreach (Mood item in k.farvedeFolk())
				{
					do
					{
						bongi.effectShow();
					}
					while (q.valid());
				}
			}
			return konto;
		}

		internal void viBønner(Vanskning vanskning)
		{
			throw new NotImplementedException();
		}
	}
}
