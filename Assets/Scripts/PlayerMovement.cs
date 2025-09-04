using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
	private GridManager _gridManager;
	public Button[] ArrowButtons;

	public Vector2Int GridPosition;
	
    void Start()
    {
		_gridManager = GameObject.Find("HandlerObject").GetComponent<GridManager>();
		
		for(ushort i = 0; i < 8; i++)
		{
			ArrowButtons[i].onClick.AddListener(() => OnArrowClick(i));
		}
		
		GridPosition.x = _gridManager.cols / 2;
		GridPosition.y = _gridManager.rows / 2;
    }
	
	void OnArrowClick(ushort dirIndex) 
	{
		GridPosition = TryMove(dirIndex);
		Debug.Log($"player pos: {GridPosition}");
	}

	Vector2Int TryMove(ushort dirIndex)
	{
		Vector2Int newPosition = GridLogic.Vector2IntSum(GridPosition, GridLogic.VecDirectionValues[dirIndex]);
		if(!_gridManager.ZoneInBounds(newPosition, _gridManager)) return GridPosition;

		return newPosition;
	}
}

