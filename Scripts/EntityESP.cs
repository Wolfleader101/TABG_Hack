using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TABG_Hack.Utils;
using UnityEngine;

namespace TABG_Hack.Scripts
{
	class EntityESP : MonoBehaviour
	{
		private List<Player> m_Players;
		private IEnumerator findEntitiesCoroutine;

		void Start()
		{
			m_Players = new List<Player>();
			findEntitiesCoroutine = FindEntities();
			StartCoroutine(findEntitiesCoroutine);
		}

		void OnGUI()
		{
			ESP();
		}

		private void ESP()
		{
			var mainCam = Camera.main;//this.GetComponent<Main>().mainCam;

			if (m_Players.Count == 0) return;

			foreach (var player in m_Players)
			{
				if (player == null) return;
				if (player.m_head == null) return;

				var pos = player.m_head.transform.position;
				var worldToScreen = mainCam.WorldToScreenPoint(pos);

				if (worldToScreen.z < 0 || worldToScreen.z > 150) return;

				Drawer.DrawText($"{player.name} {worldToScreen.z.ToString("0.")}m", new Vector2(worldToScreen.x, Screen.height - worldToScreen.y + 45), false, 16, Color.green);

				Drawer.DrawBox(new Vector2(worldToScreen.x, Screen.height - worldToScreen.y), 25, 40, Color.red);
			}
		}

		private IEnumerator FindEntities()
		{
			for (; ; )
			{
				m_Players = FindObjectsOfType<Player>().ToList();
				yield return new WaitForSeconds(2f);
				m_Players = FindObjectsOfType<Player>().ToList();
				if (m_Players.Count > 0)
				{
					//StopCoroutine(findEntitiesCoroutine);
					foreach (var player in m_Players)
					{
						Debug.LogWarning($"{player.name} Object Found");
					}
				}
			}

		}
	}
}
