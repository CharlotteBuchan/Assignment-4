
using UnityEngine;


public class GameManager : MonoBehaviour
{



	float curTimePlusDelay;

	bool isTimeUp {
		get {
			return Time.unscaledTime > curTimePlusDelay;
		}
	}



}
