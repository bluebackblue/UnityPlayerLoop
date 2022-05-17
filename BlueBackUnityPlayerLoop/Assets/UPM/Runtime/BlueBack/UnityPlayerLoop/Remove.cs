

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ユニティープレイヤーループ。削除。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** Remove
	*/
	public static class Remove
	{
		/** RemoveFromType
		*/
		public static void RemoveFromType(ref UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem,System.Type a_type)
		{
			int t_index_1;
			int t_index_2;
			int t_index_3;
			int t_index_count = Find.FindFromType(a_playerloopsystem,a_type,out t_index_1,out t_index_2,out t_index_3);

			switch(t_index_count){
			case 1:
				{
					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList);
					t_sub_list.RemoveAt(t_index_1);
					a_playerloopsystem.subSystemList = t_sub_list.ToArray();
				}break;
			case 2:
				{
					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList);
					t_sub_list.RemoveAt(t_index_2);
					a_playerloopsystem.subSystemList[t_index_1].subSystemList = t_sub_list.ToArray();
				}break;
			case 3:
				{
					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList);
					t_sub_list.RemoveAt(t_index_3);
					a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList = t_sub_list.ToArray();
				}break;
			}
		}
	}
}

