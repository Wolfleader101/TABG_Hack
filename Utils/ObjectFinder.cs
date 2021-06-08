using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TABG_Hack.Utils
{
	static class ObjectFinder
	{
		//private static float timeCache;


		public static bool HasComponent<T>(this GameObject flag) where T : Component
		{
			return !(flag == null) && flag.GetComponent<T>() != null;
		}

		public static T FindActiveObject<T>() where T : MonoBehaviour
		{
			Transform[] array = Resources.FindObjectsOfTypeAll<Transform>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].hideFlags == HideFlags.None && array[i].gameObject.HasComponent<T>())
				{
					return array[i].GetComponent<T>();
				}
			}
			return default(T);
		}


		//public static T CacheObject<T>(float curTime, float waitTime) where T : MonoBehaviour
		//{
		//	T _obj = default(T);


		//	if (curTime >= timeCache)
		//	{
		//		timeCache = curTime + waitTime;
		//		_obj = FindActiveObject<T>();
		//		if(_obj != null)
		//		{
		//			Debug.LogError($"{_obj.GetType()}");
		//			return _obj;
		//		}
		//	}

		//	return _obj;
		//}

		//public List<T> CacheObjects<T>(float curTime, float waitTime) where T : Object
		//{
		//	List<T> _obj = null;

		//	if (curTime >= timeCache)
		//	{
		//		timeCache = curTime + waitTime;
		//		_obj = Object.FindObjectsOfType<T>().ToList();
		//	}

		//	return _obj;
		//}
	}
}
