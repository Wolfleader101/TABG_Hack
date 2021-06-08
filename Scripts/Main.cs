using TABG_Hack.Utils;
using UnityEngine;
using System.Collections;
using HarmonyLib;
using System.Collections.Generic;

namespace TABG_Hack.Scripts
{
	class Main : MonoBehaviour
	{
		//		private Player m_Player;

		//		public Camera mainCam;

		//		public bool showMenu = true;

		//		private IEnumerator findPlayerCoroutine;

		void Start()
		{
			AddScripts();


			//mainCam = Camera.main;
		}
		//		void Update()
		//		{
		//			//mainCam = (Camera)ObjectFinder.CacheObject<Camera>(Time.time, 5f);
		//			//m_Player = (Player)ObjectFinder.CacheObject<Player>(Time.time, 5f);

		//			//if (m_Player != null)
		//			//{
		//			//	Debug.LogWarning("Player Object Found");
		//			//	GetPlayerStats();
		//			//	PrintPlayerStats();
		//			//}


		//			HandleInput();

		//		}

		//		void OnGUI()
		//		{
		//			Drawer.DrawText("Raft Trainer", new Vector2(Screen.width / 2, 10), false, 20, FontStyle.Bold, Color.cyan);


		//			MenuMaker.MakeBox("Raft Trainer", new Vector2(200, showMenu ? 250 : 50), new Vector2(10, 10));
		//			MenuMaker.MakeToggle("Show/Hide", new Vector2(100, 20), new Vector2(20, 30), showMenu, out showMenu);

		//			if(showMenu) MenuMaker.MakeButton("Increase HP", new Vector2(80, 20), new Vector2(20, 50), IncreaseHealth)
		//;
		//		}

		private void AddScripts()
		{
			List<MonoBehaviour> compList = new List<MonoBehaviour>();
			//this.gameObject.AddComponent<SharkHack>();
			this.gameObject.AddComponent<EntityESP>();
			this.gameObject.GetComponents<MonoBehaviour>(compList);
			foreach (Component comp in compList)
			{
				Debug.LogError($"{comp.GetType().Name} Initialized");
			}
		}

		//		private void HandleInput()
		//		{
		//			if (!Input.anyKey || !Input.anyKeyDown) return;


		//			if (Input.GetKeyDown(KeyCode.UpArrow) && m_Player != null)
		//			{
		//				IncreaseHealth();
		//			}

		//			if (Input.GetKeyDown(KeyCode.K) && m_Player != null)
		//			{
		//				KillShark();
		//			}

		//			//if (Input.GetKeyDown(KeyCode.Delete))
		//			//{
		//			//	Loader.Unload();
		//			//}
		//		}

		//		private IEnumerator FindPlayer()
		//		{
		//			while (m_Player == null)
		//			{
		//				m_Player = FindObjectOfType<Player>();
		//				yield return new WaitForSeconds(5f);
		//				m_Player = FindObjectOfType<Player>();
		//			}
		//			StopCoroutine(findPlayerCoroutine);
		//			Debug.LogWarning("Player Object Found");
		//			GetPlayerStats();
		//			PrintPlayerStats();
		//		}

		//		private void GetPlayerStats()
		//		{
		//			m_PlayerStats = m_Player?.GetComponent<PlayerStats>();
		//			m_PlayerHealth = m_PlayerStats?.stat_health;
		//		}
		//		private void PrintPlayerStats()
		//		{
		//			Debug.Log($"Player HP: {m_PlayerStats?.stat_health.Value} \nMax HP: {m_PlayerStats?.stat_health.Max}");
		//		}

		//		private void IncreaseHealth()
		//		{
		//			if (m_PlayerStats == null) return;
		//			m_PlayerStats.stat_health.Value += 15f;
		//			var msg = $"New Player HP: {m_PlayerStats?.stat_health.Value}";
		//			ChatManager.SendDebugChatMessage(msg);
		//			Debug.Log(msg);
		//		}

		//		private void KillShark()
		//		{
		//			_Shark = FindObjectOfType<AI_StateMachine_Shark>();
		//			if (_Shark != null)
		//			{
		//				Destroy(_Shark);
		//				Debug.LogError("SHARK HAS BEEN DESTROYED");
		//			}
		//		}
	}
}