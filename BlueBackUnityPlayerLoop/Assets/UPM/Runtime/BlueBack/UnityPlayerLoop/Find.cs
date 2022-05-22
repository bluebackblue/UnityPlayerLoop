

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ユニティープレイヤーループ。検索。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** Find
	*/
	public static class Find
	{
		/** ３階層までを探査。

			a_playerloopsystem		: プレイヤーループシステム。
			a_type					: 検索するタイプ。

			a_index_1				: 検索結果。
			a_index_2				: 検索結果。
			a_index_3				: 検索結果。

			return					: 検索結果の有効数。

		*/
		public static int FindFromType(in UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem,System.Type a_type,out int a_index_1,out int a_index_2,out int a_index_3)
		{
			if(a_playerloopsystem.subSystemList != null){
				for(int ii=0;ii<a_playerloopsystem.subSystemList.Length;ii++){
					if(a_playerloopsystem.subSystemList[ii].type == a_type){
						a_index_1 = ii;
						a_index_2 = -1;
						a_index_3 = -1;
						return 1;
					}else if(a_playerloopsystem.subSystemList[ii].subSystemList != null){
						for(int jj=0;jj<a_playerloopsystem.subSystemList[ii].subSystemList.Length;jj++){
							if(a_playerloopsystem.subSystemList[ii].subSystemList[jj].type == a_type){
								a_index_1 = ii;
								a_index_2 = jj;
								a_index_3 = -1;
								return 2;
							}else if(a_playerloopsystem.subSystemList[ii].subSystemList[jj].subSystemList != null){
								for(int kk=0;kk<a_playerloopsystem.subSystemList[ii].subSystemList[jj].subSystemList.Length;kk++){
									if(a_playerloopsystem.subSystemList[ii].subSystemList[jj].subSystemList[kk].type == a_type){
										a_index_1 = ii;
										a_index_2 = jj;
										a_index_3 = kk;
										return 3;
									}
								}
							}
						}
					}else{

					}
				}
			}

			//未発見。

			#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
			DebugTool.Assert(false);
			#endif

			a_index_1 = -1;
			a_index_2 = -1;
			a_index_3 = -1;
			return -1;
		}
	}
}

