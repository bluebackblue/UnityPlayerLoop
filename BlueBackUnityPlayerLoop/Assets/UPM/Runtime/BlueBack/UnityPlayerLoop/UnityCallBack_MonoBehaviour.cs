

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ユニティープレイヤーループ。コールバック。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** UnityCallBack_MonoBehaviour
	*/
	public sealed class UnityCallBack_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** OnDestroy
		*/
		private void OnDestroy()
		{
			UnityPlayerLoop.UnityDestory();
		}
	}
}

