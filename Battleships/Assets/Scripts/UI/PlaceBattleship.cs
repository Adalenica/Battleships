using Systems;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class PlaceBattleship : MonoBehaviour
	{
		[SerializeField] private Button _myButton;
		[SerializeField] private GameObject _waypoint;
		[SerializeField] private GameObject _battleship;
		[SerializeField] private GameObject _playerGrid;
		[SerializeField] private GameObject _targetGrid;
		[SerializeField] private BattleshipPosition _battleshipPosition;
		[SerializeField] private int _waypointNumber;
	
		private void Awake()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}
		
		private void ButtonClicked()
		{
			_battleship.SetActive(true);
			_battleship.transform.position = _waypoint.transform.position;
			
			_battleshipPosition.SetPosition(_waypointNumber);
			
			_targetGrid.SetActive(true);
			_playerGrid.SetActive(false);
		}
	}
}
