﻿namespace ServerCleaner
{
	public class PlayerSpammer : RepeatedAction
	{
		private int timesNotified;

		public PlayerSpammer(double interval) : base(interval)
		{
		}

		protected override void Run()
		{
			timesNotified++;
			Utilities.ShowMessageFromServer(string.Format("This is a test. Something could have happened {0} time(s).", timesNotified));
		}
	}
}
