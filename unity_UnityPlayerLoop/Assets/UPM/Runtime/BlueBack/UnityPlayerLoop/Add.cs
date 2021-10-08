

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief ユニティープレイヤーループ。追加。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** Add
	*/
	public class Add
	{
		/** Find

			a_playerloopsystem		: プレイヤーループシステム。
			a_mode					: モード。
			a_target_type			: 追加場所。
			a_type					: タイプ。
			a_function				: 関数。

		*/
		public static void AddFromType(ref UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem,Mode a_mode,System.Type a_target_type,System.Type a_type,UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction a_function)
		{
			int t_index_1;
			int t_index_2;
			int t_index_3;
			int t_index_count = Find.FindFromType(a_playerloopsystem,a_target_type,out t_index_1,out t_index_2,out t_index_3);

			UnityEngine.LowLevel.PlayerLoopSystem t_item = new UnityEngine.LowLevel.PlayerLoopSystem();
			{
				t_item.subSystemList = null;
				t_item.type = a_type;
				t_item.updateDelegate = a_function;
			}

			int t_target_index;
			System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> t_target_list;
			{
				switch(a_mode){
				case Mode.AddFirst:
				case Mode.AddLast:
					{
						t_target_index = -1;

						switch(t_index_count){
						case 1:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList);
							}break;
						case 2:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList);
							}break;
						case 3:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList[t_index_3].subSystemList);
							}break;
						default:
							{
								//未発見。

								#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
								DebugTool.Assert(false);
								#endif

								t_target_list = null;
							}break;
						}
					}break;
				case Mode.AddBefore:
				case Mode.AddAfter:
					{
						switch(t_index_count){
						case 1:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList);
								t_target_index = t_index_1;
							}break;
						case 2:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList);
								t_target_index = t_index_2;
							}break;
						case 3:
							{
								t_target_list = new System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem>(a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList);
								t_target_index = t_index_3;
							}break;
						default:
							{
								//未発見。

								#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
								DebugTool.Assert(false);
								#endif

								t_target_list = null;
								t_target_index = -1;
							}break;
						}
					}break;
				default:
					{
						//不明なタイプ。

						#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
						DebugTool.Assert(false);
						#endif

						t_target_list = null;
						t_target_index = -1;
					}break;
				}
			}

			//追加。
			{
				switch(a_mode){
				case Mode.AddFirst:
					{
						t_target_list.Insert(0,t_item);
					}break;
				case Mode.AddLast:
					{
						t_target_list.Add(t_item);
					}break;
				case Mode.AddBefore:
					{
						t_target_list.Insert(t_target_index,t_item);
					}break;
				case Mode.AddAfter:
					{
						t_target_list.Insert(t_target_index + 1,t_item);
					}break;
				default:
					{
						//不明なタイプ。

						#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
						DebugTool.Assert(false);
						#endif
					}break;
				}	
			}

			//適応。
			{
				switch(a_mode){
				case Mode.AddFirst:
				case Mode.AddLast:
					{
						switch(t_index_count){
						case 1:
							{
								a_playerloopsystem.subSystemList[t_index_1].subSystemList = t_target_list.ToArray();
							}break;
						case 2:
							{
								a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList = t_target_list.ToArray();
							}break;
						case 3:
							{
								a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList[t_index_3].subSystemList = t_target_list.ToArray();
							}break;
						default:
							{
								//未発見。

								#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
								DebugTool.Assert(false);
								#endif
							}break;
						}
					}break;
				case Mode.AddBefore:
				case Mode.AddAfter:
					{
						switch(t_index_count){
						case 1:
							{
								a_playerloopsystem.subSystemList = t_target_list.ToArray();
							}break;
						case 2:
							{
								a_playerloopsystem.subSystemList[t_index_1].subSystemList = t_target_list.ToArray();
							}break;
						case 3:
							{
								a_playerloopsystem.subSystemList[t_index_1].subSystemList[t_index_2].subSystemList = t_target_list.ToArray();
							}break;
						default:
							{
								//未発見。

								#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
								DebugTool.Assert(false);
								#endif
							}break;
						}
					}break;
				default:
					{
						//不明なタイプ。

						#if(DEF_BLUEBACK_UNITYPLAYERLOOP_ASSERT)
						DebugTool.Assert(false);
						#endif
					}break;
				}
			}
		}
	}
}

