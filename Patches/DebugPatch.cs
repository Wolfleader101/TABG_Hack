using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABG_Hack.Patches
{
	[HarmonyPatch(typeof(NoDebugThanks))]
	class DebugPatch
	{

		[HarmonyPrefix]
		[HarmonyPatch("Update")]
		static void Prefix1(ref bool ___stopIt)
		{
			___stopIt = true;
		}
	}
}
