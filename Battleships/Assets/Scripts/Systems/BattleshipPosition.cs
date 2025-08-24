using UnityEngine;

namespace Systems
{
	public class BattleshipPosition : MonoBehaviour
	{
		public float BattleshipPossition;
		public float EnemyBattleshipPosition;
		
		[SerializeField] private Randomiser _randomiser;

		private void Start()
		{
			EnemyBattleshipPosition = _randomiser.Randomise(1,9);
		}
		
		public void SetPosition(float pos)
		{
			BattleshipPossition = pos;
		}
	}
}
