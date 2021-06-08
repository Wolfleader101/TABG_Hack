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
		static bool Prefix1(ref bool ___m_initialized)
		{
			___m_initialized = true;
			return true;
		}

	}

	[HarmonyPatch(typeof(equ8.client))]
	class EqClientPatch
	{

		[HarmonyPrefix]
		[HarmonyPatch("initialize")]
		static bool Prefix1(ref equ8.equ8_err __result, ref bool ___is_initialized)
		{
			___is_initialized = true;
			__result = equ8.equ8_err.create(0UL);
			return true;
		}

		[HarmonyPrefix]
		[HarmonyPatch("resolve_api")]
		static bool Prefix2(ref equ8.equ8_err __result)
		{
			__result = equ8.equ8_err.create(0UL);
			return true;
		}
	}

	[HarmonyPatch(typeof(equ8.dll_helper))]
	class EqDllPatch
	{

		[HarmonyPrefix]
		[HarmonyPatch("LoadLibrary")]
		static bool Prefix1()
		{
			return true;
		}
	}
}
