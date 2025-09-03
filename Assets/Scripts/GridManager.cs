using UnityEngine;

public class GridManager : MonoBehaviour
{
	public int cols, rows;
	public ScriptableObject[,] zones;

    void Start()
    {

    }

	public bool ZoneInBounds(Vector2Int pos, GridManager gridManager)
	{
		return (
			pos.x > -1 &&
			pos.y > -1 &&
			pos.x < gridManager.cols &&
			pos.y < gridManager.rows 
		);
	}
}
