

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
		public static void SetDefaultPlayerLoopOnUnityDestroy(string a_objectname)
		{
			if(UnityPlayerLoop.gameobject == null){
				string t_objectname = a_objectname;

				if(a_objectname != null){
					t_objectname = a_objectname;
				}else{
					t_objectname = "unityplayerloop";
				}

				UnityPlayerLoop.gameobject = new UnityEngine.GameObject(t_objectname);
				UnityEngine.GameObject.DontDestroyOnLoad(UnityPlayerLoop.gameobject);
				UnityPlayerLoop.gameobject.AddComponent<UnityCallBack_MonoBehaviour>();
				#if(DEF_BLUEBACK_UNITYPLAYERLOOP_HIDEINNERGAMEOBJECT)
				t_gameobject.hideFlags = UnityEngine.HideFlags.HideInHierarchy;
				#endif
			}
		}

		/** UnityCallBack_MonoBehaviourから呼び出される。
		*/
		public static void UnityDestory()
		{
			#if(DEF_BLUEBACK_DEBUG_LOG)
			DebugTool.Log("SetPlayerLoop : default");
			#endif

			UnityPlayerLoop.SetPlayerLoop(UnityPlayerLoop.GetDefaultPlayerLoop());
		}
	}
}

