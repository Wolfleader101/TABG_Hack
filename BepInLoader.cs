using UnityEngine;
using System;
using System.Reflection;
using System.Collections;
using BepInEx;

namespace TABG_Hack
{
    [BepInPlugin("TABG_Hack", "TABG Hack", "1.0.0")]
    public class BepInLoader : BaseUnityPlugin
    {
        public static BepInLoader instance;

        private bool startFired;

        void Awake()
		{
            BepInLoader.instance = this;
            base.transform.parent = null;
			UnityEngine.Object.DontDestroyOnLoad(this);

            base.StartCoroutine(this.StartEx());
		}

        void Start()
		{
            if(!this.startFired)
			{
                Loader.injectionMethod = Loader.InjectionMethod.BepInEx;
                Loader.Init();
                this.startFired = true;
			}
		}

        private IEnumerator StartEx()
		{
            this.Start();
            yield return new WaitForSeconds(5f);
            if(!Loader.initialized)
			{
                this.startFired = false;
                this.Start();
			}
            yield break;
		}
 
    }
}
