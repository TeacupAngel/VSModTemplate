using System;
using System.Collections.Generic;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace Example
{
	public class ExampleModSystem : ModSystem
	{
		public override void StartServerSide(ICoreServerAPI sapi)
		{
			sapi.Logger.Notification("ExampleModSystem: Congrats, your new mod is working! :)");
		}
	}
}