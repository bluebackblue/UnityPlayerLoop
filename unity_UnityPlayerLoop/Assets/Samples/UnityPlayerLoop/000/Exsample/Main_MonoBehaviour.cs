

/** Samples.UnityPlayerLoop.Exsample
*/
namespace Samples.UnityPlayerLoop.Exsample
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Start
		*/
		private void Start()
		{
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

		/** Update
		*/
		private void Update()
		{
		}
	}
}

