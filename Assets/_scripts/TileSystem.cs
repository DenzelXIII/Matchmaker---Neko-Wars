using UnityEngine;
using System.Collections;

public class TileSystem : MonoBehaviour
{
    public GameObject tile;
    public Vector2 mapSize;

    [Range(0,1)]
    public float outline;


	// Use this for initialization
	void Start ()
    {
        TileSpawner();
	}

    public void TileSpawner()
    {
        string holderName = "map";
        Transform mapHolder = new GameObject(holderName).transform;

        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 tilePos = new Vector3(-mapSize.x / 2 + x, 0, -mapSize.y / 2 + y);
                Transform newTile = Instantiate(tile, tilePos, Quaternion.Euler(Vector3.right*90)) as Transform;
               // newTile.parent = mapHolder.transform;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
