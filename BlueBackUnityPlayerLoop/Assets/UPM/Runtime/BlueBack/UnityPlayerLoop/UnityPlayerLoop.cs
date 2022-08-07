

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ユニティープレイヤーループ。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** UnityPlayerLoop
	*/
	public static class UnityPlayerLoop
	{
		/** gameobject
		*/
		private static UnityEngine.GameObject gameobject = null;

		/** GetCurrentPlayerLoop
		*/
		public static UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop()
		{
			return UnityEngine.LowLevel.PlayerLoop.GetCurrentPlayerLoop();
		}

		/** GetDefaultPlayerLoop
		*/
		public static UnityEngine.LowLevel.PlayerLoopSystem GetDefaultPlayerLoop()
		{
			return UnityEngine.LowLevel.PlayerLoop.GetDefaultPlayerLoop();
		}

		/** SetPlayerLoop
		*/
		public static void SetPlayerLoop(in UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem)
		{
			UnityEngine.LowLevel.PlayerLoop.SetPlayerLoop(a_playerloopsystem);
		}

		/** 削除時にデフォルトに戻す。
		*/
		public static void SetDefaultPlayerLoopOnUnityDestroy()
		{
			if(UnityPlayerLoop.gameobject == null){
				UnityPlayerLoop.gameobject = new UnityEngine.GameObject("UnityPlayerLoop");
				UnityEngine.GameObject.DontDestroyOnLoad(UnityPlayerLoop.gameobject);
				UnityPlayerLoop.gameobject.AddComponent<CallBack_OnUnityDestroy_MonoBehaviour>();
				#if(DEF_BLUEBACK_UNITYPLAYERLOOP_HIDEINNERGAMEOBJECT)
				t_gameobject.hideFlags = UnityEngine.HideFlags.HideInHierarchy;
				#endif
			}
		}

		/** OnUnityDestory
		*/
		public static void OnUnityDestory()
		{
			#if(DEF_BLUEBACK_LOG)
			DebugTool.Log("UnityPlayerLoop : default");
			#endif

			UnityPlayerLoop.SetPlayerLoop(UnityPlayerLoop.GetDefaultPlayerLoop());
		}
	}
}

