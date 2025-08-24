using Systems;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class TargetingClick: MonoBehaviour
	{
		[SerializeField] private Button _myButton;
		[SerializeField] private int _id;
		[SerializeField] private BattleshipPosition _battleshipPosition;
		
		private void Awake()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}

		private void ButtonClicked()
		{
			if (Mathf.Approximately(_battleshipPosition.BattleshipPossition, _id))
			{
				Debug.Log("Hit!");
			}
			else
			{
				Debug.Log("Miss!");
			}
		}
	}
}