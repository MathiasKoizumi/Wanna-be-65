using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Jongo
	{
		private List<Jingo> john = new List<Jingo>();

		private JoyRomeo jonga;

		private Jingo jin;

		private Juklas biffy = new Juklas();

		private BolleHeaven k;

		private List<Jingo> kusMig = new List<Jingo>();

		private Form1 form1;

		public Jongo(Form1 form)
		{
			form1 = form;
			jonga = new JoyRomeo(form1);
			jin = new Jingo(form1);
			fillList(jonga.partyTime());
			k = new BolleHeaven(john);
			jonga = new JoyRomeo(form1);
		}

		public void fillList(Jingo troja)
		{
			for (int i = 0; i < 50; i++)
			{
				troja = troja.changeCourse();
				troja.moodChange(troja, biffy);
				john.Add(jin);
			}
		}

		public List<Jingo> getJohn()
		{
			form1.brunstigCookie(new Børnetid(new Afmagt(1000.0, 3000f, form1)), 9000);
			return john;
		}

		private BolleHeaven callJongo(int t)
		{
			k.bolledej(t, t + 12);
			return k;
		}

		internal void blivHosMig(int p)
		{
			throw new NotImplementedException();
		}

		internal List<Jingo> fillJoy(Jonga jonga)
		{
			for (int i = 0; i < jonga.getNumbing(4000); i++)
			{
				kusMig.Add(jin);
			}
			return kusMig;
		}
	}
}
