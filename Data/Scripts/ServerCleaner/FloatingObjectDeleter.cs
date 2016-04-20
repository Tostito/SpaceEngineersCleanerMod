﻿using VRage.Game.ModAPI;

namespace ServerCleaner
{
	public class FloatingObjectDeleter : RepeatedDeleter<IMyFloatingObject, DeletionContext>
	{
		public FloatingObjectDeleter(double interval, double playerDistanceTreshold) : base(interval, playerDistanceTreshold, new DeletionContext())
		{
		}

		protected override void AfterDeletion(DeletionContext context)
		{
			if (context.EntitiesForDeletion.Count == 0)
				return;

			Utilities.ShowMessageFromServer("Deleted {0} floating object(s) with no players within {1} m.", context.EntitiesForDeletion.Count, PlayerDistanceThreshold);
		}
	}
}
