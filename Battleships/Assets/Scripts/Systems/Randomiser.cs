using UnityEngine;

namespace Systems
{
	public class Randomiser: MonoBehaviour
	{
		public float Randomise(float min, float max)
		{
			var randomNumber = Random.Range(min, max);
			return randomNumber;
		}
	}
}