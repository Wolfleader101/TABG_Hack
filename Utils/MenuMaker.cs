using UnityEngine;
using System.Collections;
using System;

namespace TABG_Hack.Utils
{
	class MenuMaker
	{
		public static void MakeBox(string name, Vector2 size, Vector2 position)
		{
			GUI.Box(new Rect(position.x,position.y, size.x, size.y), name);
		}

		public static void MakeButton(string name, Vector2 size, Vector2 position, Action callback)
		{
			if (GUI.Button(new Rect(position.x, position.y, size.x, size.y), name))
			{
				callback();
			}
		}

		public static void MakeToggle(string name, Vector2 size, Vector2 position, bool inToggle, out bool toggle)
		{
			toggle = GUI.Toggle(new Rect(position.x, position.y, size.x, size.y), inToggle, name);
		}
	}
}
