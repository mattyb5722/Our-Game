using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    public TileBase tile;
    public Tilemap defaultTilemap;
    private Tilemap currentTilemap = null;

    public float scale = 1f;
    public float threshold = 0.5f;

    public bool update = true;

    private void FixedUpdate()
    {
        if (!update)
        {
            return;
        }
        print("UPDATE");

        if (currentTilemap != null)
        {
            Destroy(currentTilemap.gameObject);
        }

        currentTilemap = GameObject.Instantiate(defaultTilemap);
        currentTilemap.transform.parent = transform;
        currentTilemap.gameObject.SetActive(true);


        foreach (var pos in currentTilemap.cellBounds.allPositionsWithin)
        {
            float x = (float)pos.x / currentTilemap.cellBounds.size.x * scale;
            float y = (float)pos.y / currentTilemap.cellBounds.size.y * scale;

            float noise = Mathf.PerlinNoise(x, y);

            if (noise > threshold)
            {
                currentTilemap.SetTile(new Vector3Int(pos.x, pos.y, 0), tile);
            }
        }

        update = false;
    }
}
