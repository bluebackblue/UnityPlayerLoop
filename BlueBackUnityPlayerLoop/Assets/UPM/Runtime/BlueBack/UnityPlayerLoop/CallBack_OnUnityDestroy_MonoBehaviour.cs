

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ユニティープレイヤーループ。コールバック。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** CallBack_OnUnityDestroy_MonoBehaviour
	*/
	public sealed class CallBack_OnUnityDestroy_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** OnDestroy
		*/
		private void OnDestroy()
		{
			UnityPlayerLoop.OnUnityDestory();
		}
	}
}

