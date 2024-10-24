using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class MapGenerator : MonoBehaviour
{
    public TileBase tile;
    public Tilemap defaultTilemap;
    private Tilemap currentTilemap = null;

    public float threshold = 0.75f;
    public float[] scaleBounds = new float[2];

    public bool update = true;

    private void FixedUpdate()
    {
        if (!update)
        {
            return;
        }

        if (currentTilemap != null)
        {
            Destroy(currentTilemap.gameObject);
        }

        float scale = Random.Range(scaleBounds[0], scaleBounds[1]);

        currentTilemap = GameObject.Instantiate(defaultTilemap);
        currentTilemap.transform.parent = transform;
        currentTilemap.gameObject.SetActive(true);

        foreach (Vector3Int pos in currentTilemap.cellBounds.allPositionsWithin)
        {

            float x = (float) (pos.x + ((float)currentTilemap.cellBounds.size.x / 2.0f)) / currentTilemap.cellBounds.size.x * scale;
            float y = (float) (pos.y + ((float)currentTilemap.cellBounds.size.y / 2.0f)) / currentTilemap.cellBounds.size.y * scale;

            if (Mathf.PerlinNoise(x, y) > threshold)
            {
                currentTilemap.SetTile(pos, tile);
            }
        }

        update = false;
    }
}
