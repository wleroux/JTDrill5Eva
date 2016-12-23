using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace JTDrill5Eva
{
	public class JTDrill5Eva : CompDeepDrill
    {
		private void ProduceLump()
		{
			ThingDef def;
			int num;
			IntVec3 c;
			if (this.TryGetNextResource(out def, out num, out c))
			{
                Thing thing = ThingMaker.MakeThing(def, null);
				thing.stackCount = Mathf.Min(num, 75);
				GenPlace.TryPlaceThing(thing, this.parent.InteractionCell, this.parent.Map, ThingPlaceMode.Near, null);
				return;
			}
			Log.Error("Drill tried to ProduceLump but couldn't.");
		}
	}
}
