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
			ushort dir_id = i;
			ArrowButtons[i].onClick.AddListener(() => Move(dir_id));
		}
    }
	
	void Move(ushort DirIndex) 
	{
		//GridPosition.x += direction.x;
		//GridPosition.y += direction.y;
		
		//Debug.Log($"player pos: {GridPosition}");

		//Debug.Log($"{DirIndex}");

		GridPosition = GridLogic.Vector2IntSum(GridPosition, GridLogic.VecDirectionValues[DirIndex]);
		Debug.Log($"player pos: {GridPosition}");
	}
}
