

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

			return == false : 失敗。

		*/
		public static bool RemoveFromType(ref UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem,System.Type a_type)
		{
			//index
			int t_index_1;
			int t_index_2;
			int t_index_3;
			int t_index_count = Find.FindFromType(a_playerloopsystem,a_type,out t_index_1,out t_index_2,out t_index_3);

			switch(t_index_count){
			case 1:
				{
					//１階層目に発見。

					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList);
					t_sub_list.RemoveAt(t_index_1);
					a_playerloopsystem.subSystemList = t_sub_list.ToArray();
				}return true;
			case 2:
				{
					//２階層目に発見。

					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList);
					t_sub_list.RemoveAt(t_index_2);
					a_playerloopsystem.subSystemList[t_index_1].subSystemList = t_sub_list.ToArray();
				}return true;
			case 3:
				{
					//３階層目に発見。

					System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_sub_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList);
					t_sub_list.RemoveAt(t_index_3);
					a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList = t_sub_list.ToArray();
				}return true;
			default:
				{
					//未発見。
				}return false;
			}
		}
	}
}

