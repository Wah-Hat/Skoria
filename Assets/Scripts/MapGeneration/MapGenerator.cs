using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase tile;

    public int lineLength = 10;
    public float tileSpacing = 1f;

    void Start()
    {
    }

    public TileBase railLine(Vector3Int start, Vector3Int end)
    {
        tilemap.SetTile(new Vector3Int(0, 0, 0), tile);
        return null;
    }
}
