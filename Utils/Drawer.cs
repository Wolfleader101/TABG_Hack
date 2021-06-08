using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TABG_Hack.Utils
{
	class Drawer
	{
		public static GUIStyle TextStyle { get; set; } = new GUIStyle(GUI.skin.label);

		private const int _defaultFontSize = 14;
		private const FontStyle _defaultFontStyle = FontStyle.Normal;

		public static void DrawText(string name, Vector2 position)
		{
			_DrawText(name, position, false, _defaultFontSize, _defaultFontStyle, null);
		}

		public static void DrawText(string name, Vector2 position, bool centered)
		{
			_DrawText(name, position, centered, _defaultFontSize, _defaultFontStyle, null);
		}


		public static void DrawText(string name, Vector2 position, bool centered, int fontSize = _defaultFontSize)
		{
			_DrawText(name, position, centered, fontSize, _defaultFontStyle, null);
		}


		public static void DrawText(string name, Vector2 position, bool centered, int fontSize = _defaultFontSize, Color? color = null)
		{
			_DrawText(name, position, centered, fontSize, _defaultFontStyle, color);
		}


		public static void DrawText(string name, Vector2 position, bool centered, int fontSize = _defaultFontSize, FontStyle fontStyle = _defaultFontStyle)
		{
			_DrawText(name, position, centered, fontSize, fontStyle, null);
		}

		public static void DrawText(string name, Vector2 position, bool centered, int fontSize = _defaultFontSize, FontStyle fontStyle = _defaultFontStyle, Color? color = null)
		{
			_DrawText(name, position, centered, fontSize, fontStyle, color);
		}


		private static void _DrawText(string name, Vector2 position, bool centered, int fontSize, FontStyle fontStyle, Color? color)
		{
			TextStyle.normal.textColor = color.GetValueOrDefault(Color.black);
			TextStyle.fontSize = fontSize;
			TextStyle.fontStyle = fontStyle;


			var label = new GUIContent(name);
			var size = TextStyle.CalcSize(label);
			var _pos = centered ? position - size / 2f : position;

			GUI.Label(new Rect(_pos, size), label, TextStyle);
		}

		

		public static void DrawLine(Vector2 start, Vector2 end, Color? color, int width = 5) 
		{
			GUI.depth = 0;
			Vector2 d = end - start;
			float a = Mathf.Rad2Deg * Mathf.Atan(d.y / d.x);
			if (d.x < 0)
				a += 180;

			int width2 = (int)Mathf.Ceil(width / 2);

			GUIUtility.RotateAroundPivot(a, start);
			GUI.color = color.GetValueOrDefault(Color.red);
			GUI.DrawTexture(new Rect(start.x, start.y - width2, d.magnitude, width), Texture2D.whiteTexture, ScaleMode.StretchToFill);
			GUIUtility.RotateAroundPivot(-a, start);
		}

		public static void DrawBox(Vector2 point, int height, int width, Color? color) 
		{
			DrawLine(point, new Vector2(point.x + width, point.y), color, 2);
			DrawLine(point, new Vector2(point.x, point.y + height), color, 2);
			DrawLine(new Vector2(point.x + width, point.y + height), new Vector2(point.x + width, point.y), color, 2);
			DrawLine(new Vector2(point.x + width, point.y + height), new Vector2(point.x, point.y + height), color, 2);
		}
	}
}
