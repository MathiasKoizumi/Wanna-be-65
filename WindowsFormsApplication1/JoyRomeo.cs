namespace WindowsFormsApplication1
{
	internal class JoyRomeo
	{
		private Form1 form1;

		public static Form1 form
		{
			get;
			set;
		}

		public JoyRomeo(Form1 form)
		{
			form1 = form;
		}

		internal Jingo partyTime()
		{
			return new Jingo(form1);
		}

		internal static Jongo kaldMisterJoel(Bollemælk bollemælk)
		{
			bollemælk.effectShow();
			return new Jongo(form);
		}
	}
}
