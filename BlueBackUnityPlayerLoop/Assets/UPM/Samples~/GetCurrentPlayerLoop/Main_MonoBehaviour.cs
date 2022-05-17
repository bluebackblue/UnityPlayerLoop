

/** BlueBack.UnityPlayerLoop.Samples.GetCurrentPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop.Samples.GetCurrentPlayerLoop
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Start
		*/
		private void Start()
		{
			//削除時にデフォルトに戻す。
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetDefaultPlayerLoopOnUnityDestroy();

			//列挙。
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			if(t_playerloopsystem.subSystemList != null){
				foreach(var t_item in t_playerloopsystem.subSystemList){
					UnityEngine.Debug.Log("" + t_item.type.ToString());
					foreach(var t_item_item in t_item.subSystemList){
						UnityEngine.Debug.Log(" + " + t_item_item.type.ToString());
					}
				}
			}
		}
	}
}

