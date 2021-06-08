using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace TABG_Hack.Utils
{
	class Patcher
	{
		public static void doPatching()
		{
			var harmony = new Harmony("com.tabg.hack");
			harmony.PatchAll();
		}
	}
}
