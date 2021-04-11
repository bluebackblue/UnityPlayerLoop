

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief UnityPlayerLoop。
*/


/** BlueBack.UnityPlayerLoop
*/
namespace BlueBack.UnityPlayerLoop
{
	/** UnityPlayerLoop
	*/
	public class UnityPlayerLoop
	{
		/** GetCurrentPlayerLoop
		*/
		UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop()
		{
			return UnityEngine.LowLevel.PlayerLoop.GetCurrentPlayerLoop();
		}

		/** GetDefaultPlayerLoop
		*/
		UnityEngine.LowLevel.PlayerLoopSystem GetDefaultPlayerLoop()
		{
			return UnityEngine.LowLevel.PlayerLoop.GetDefaultPlayerLoop();
		}

		/** SetPlayerLoop
		*/
		void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem a_playerloopsystem)
		{
			UnityEngine.LowLevel.PlayerLoop.SetPlayerLoop(a_playerloopsystem);
		}
	}
}

