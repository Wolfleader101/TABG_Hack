using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABG_Hack.Patches
{
	[HarmonyPatch(typeof(AntiCheatClient))]
	class AntiCheatPatch
	{

		[HarmonyPrefix]
		[HarmonyPatch("Initialize")]
		static bool Prefix1(ref bool __m_initialized)
		{
			__m_initialized = true;
			return true;
		}

	}
}
