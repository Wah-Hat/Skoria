using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase[] tiles;

    public int lineLength = 10;
    public float tileSpacing = 1f;

    void Start()
    {
        makeRail(new Vector2Int(0, 0), 70, 0, 0);
    }

    public void makeRail(Vector2Int start, int endX, int max, int index)
    {
        if (start.x >= endX || max >= 50)
        {
            return;
        }
        max++;
        Debug.Log("Lines Made: " + max);

        int randDist = Random.Range(1, 4);
        int rand = Random.Range(0, 3) + index;

        Debug.Log("rand: " + rand);
        Debug.Log("index: " + index);
        if (rand == 1)
        {
            if (index == 1)
            {
                tilemap.SetTile(new Vector3Int(start.x, start.y, 0), tiles[3]);
                start.x++;
            }
            if (index == -1)
            {
                tilemap.SetTile(new Vector3Int(start.x, start.y, 0), tiles[4]);
                start.x++;
            }
            makeRail(railLine(start, new Vector2Int(start.x + randDist*3, start.y), index), endX, max, 0);
        } else if (rand <= 0)
        {
            makeRail(railLine(start, new Vector2Int(start.x + randDist, start.y - randDist * 2), index), endX, max, -1);
        } else
        {
            makeRail(railLine(start, new Vector2Int(start.x + randDist, start.y + randDist * 2), index), endX, max, 1);
        }
    }

    public Vector2Int railLine(Vector2Int start, Vector2Int end, int index)
    {
        if (start.x > end.x)
        {
            Debug.Log("end cannot be less than start");
            throw new System.Exception();
        }

        if (start == end)
        {
            Debug.Log("start and end cannot be the same!");
            throw new System.Exception();
        }

        if (start.y == end.y)
        {
            if (start.x > end.x)
            {
                Debug.Log("Made a left line!");
                for (int i = start.x; i > end.x; i--)
                    tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[0]);
                return end;
            }
            Debug.Log("Made a rigtht line!");
            for (int i = start.x; i < end.x; i++)
                tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[0]);
            return end;
        }

        bool startOdd = false;
        bool endOdd = false;

        if (start.y % 2 != 0)
        {
            startOdd = true;
            --start.y;
        }
        if (end.y % 2 != 0)
        {
            endOdd = false;
            --end.y;
        }

        Debug.Log("checking if " + Mathf.Abs((float)(start.x - end.x) / (float)(start.y - end.y)) + " equals " + 1f / 2f);

        float check = Mathf.Abs((float)(start.x - end.x) / (float)(start.y - end.y));

        if (check == float.NaN)
        {
            Debug.Log("tiles are too close!");
            throw new System.Exception();
        }

        if (check != 1f / 2f)
        {
            Debug.Log("line is not horizontal or diagonal!");
            throw new System.Exception();
        }

        int temp;

        if (start.y > end.y)
        {
            if (index == 0)
                temp = 6;
            else
                temp = 2;
            Debug.Log("making up-right line!");
            for (int i = start.x; i <= end.x; i++)
            {
                Debug.Log("Tile at " + i + " " + start.y);
                tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[temp]);
                start.y--;
                temp = 2;
                if (start.y >= end.y)
                {
                    Debug.Log("Tile at " + i + " " + start.y);
                    tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[2]);
                    start.y--;
                }
            }
            return end;
        }

        if (index == 0)
            temp = 5;
        else
            temp = 1;
        Debug.Log("making up-right line!");
        for (int i = start.x; i <= end.x; i++)
        {
            Debug.Log("Tile at " + i + " " + start.y);
            tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[temp]);
            start.y++;
            temp = 1;
            if (start.y <= end.y)
            {
                Debug.Log("Tile at " + i + " " + start.y);
                tilemap.SetTile(new Vector3Int(i, start.y, 0), tiles[1]);
                start.y++;
            }
        }
        return end;
    }
}
