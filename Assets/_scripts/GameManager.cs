using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Grid grid;

    private int level = 3;

    void Awake()
    {
        grid = GetComponent<Grid>();
        InitGame();
    }

    void InitGame()
    {
        grid.SetUpScene(level);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
