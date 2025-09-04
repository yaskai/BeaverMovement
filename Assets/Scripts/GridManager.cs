using UnityEngine;

public class GridManager : MonoBehaviour
{
	public int cols, rows;
	public int zoneCount;
	public GameObject[] _zoneObjects;

	public Vector2 minCellSize = new Vector2(2, 2);

    void Start()
    {
		InitGrid();
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

	private void InitGrid()
	{
		Debug.Log("Inititalizing grid...");

		// Find and store zone objects to array 
		_zoneObjects = GameObject.FindGameObjectsWithTag("Zone");
		zoneCount = _zoneObjects.GetLength(0);

		Debug.Log($"found {zoneCount} zones!");

		// Find corner zone using the distance from vec2{world minimum x, world minimum x}
		// Track current shortest distance corresponding index  
		float minDist = float.MaxValue;
		int cornerIndex = 0;

		for(int i = 0; i < zoneCount; i++)
		{
			GameObject zoneObj = _zoneObjects[i];
			Vector2 zonePos = new Vector2(zoneObj.transform.position.x, zoneObj.transform.position.z);

			// Calculate distance from world minimum bounds
			// NOTE: Not sure why but, using float min value or vec2.negativeInfinity returns incorrect value
			// Used short min values as a quick fix...   
			float dist = Vector2.Distance(zonePos, new Vector2(short.MinValue, short.MinValue));

			// Update tracked shortest distance and corner index when new smaller distance is calculated 
			if(dist < minDist)
			{
				minDist = dist;
				cornerIndex = i;	
			}
		}

		Debug.Log($"corner index: {cornerIndex}");	

		// Sort zones
		GameObject[] sortedZones = new GameObject[zoneCount];
		sortedZones[0] = _zoneObjects[cornerIndex];

		// TODO: Calculate number of columns and rows...
		// NOTE: Add filler column/row if max cell distance exceeded,
		// null array values could be used for UI available directions
	}
}

