using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Tegneserie
	{
		private Lingo børnemuseum;

		private Jingo juklas;

		private JoyRomeo jongo;

		private string s;

		private Random k = new Random();

		private Form1 form1;

		public static int Hugo
		{
			get;
			set;
		}

		public Tegneserie(JoyRomeo romeo, Form1 form)
		{
			form1 = form;
			børnemuseum = new Lingo(new Børneleg().passMeTheSugar(320), new Børnetid(new Afmagt(400.0, 740f, form)), 350, form1);
			juklas = romeo.partyTime();
			jongo = romeo;
		}

		public Tegneserie(string s)
		{
			this.s = s;
		}

		internal IEnumerable<Mood> farvedeFolk()
		{
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(200));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(400));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(100));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(2000));
			throw new NotImplementedException();
		}

		internal void lineUpSi(double p, double p_2)
		{
			throw new NotImplementedException();
		}
	}
}
