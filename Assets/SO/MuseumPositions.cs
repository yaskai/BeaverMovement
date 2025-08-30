using UnityEngine;

[CreateAssetMenu(fileName = "MuseumPositions", menuName = "Scriptable Objects/MuseumPositions")]
public class MuseumPositions : ScriptableObject
{
    public Vector3 position;
    public Quaternion rotation;
    public bool isNActive;
    public bool isNEActive;
    public bool isEActive;
    public bool isSEActive;
    public bool isSActive;
    public bool isSWActive;
    public bool isWActive;
    public bool isNWActive;
}
