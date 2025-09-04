using UnityEngine;

public static class GridLogic 
{
	public enum Directions {
		NorthWest 		= 0,
		North			= 1,
		NorthEast		= 2,
		West			= 3,
		East			= 4,
		SouthWest		= 5,
		South			= 6,
		SouthEast		= 7
	};

	public static Vector2Int[] VecDirectionValues = {
		new Vector2Int( -1,   1 ),	// North West
		new Vector2Int(  0,   1 ),	// North	
		new Vector2Int( -1,   1 ), 	// North East
		new Vector2Int( -1,   0 ),	// East
	 	new Vector2Int(  1,   0 ),	// West
		new Vector2Int(  1,  -1 ),	// South West
		new Vector2Int(  0,  -1 ),	// South
		new Vector2Int(  1,  -1 )   // South East
	};

	public static Vector2Int DirToVec(ushort dir) 
	{
		return VecDirectionValues[dir];
	}

	public static Vector2Int Vector2IntSum(Vector2Int a, Vector2Int b) {
		return new Vector2Int(a.x + b.x, a.y + b.y);
	}
}

