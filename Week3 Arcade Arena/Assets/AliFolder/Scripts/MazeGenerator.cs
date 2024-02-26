using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
      public int width = 10;
    public int height = 10;
    public GameObject wallPrefab;

    private int[,] maze;

    void Start()
    {
        maze = new int[width, height];
        GenerateMaze(0, 0);
        DrawMaze();
    }

    void GenerateMaze(int x, int y)
    {
        maze[x, y] = 1;

        List<int> directions = new List<int> { 1, 2, 3, 4 };
        Shuffle(directions);

        foreach (int direction in directions)
        {
            switch (direction)
            {
                case 1: // Up
                    if (y > 1 && maze[x, y - 2] == 0)
                    {
                        maze[x, y - 1] = 1;
                        GenerateMaze(x, y - 2);
                    }
                    break;
                case 2: // Right
                    if (x < width - 2 && maze[x + 2, y] == 0)
                    {
                        maze[x + 1, y] = 1;
                        GenerateMaze(x + 2, y);
                    }
                    break;
                case 3: // Down
                    if (y < height - 2 && maze[x, y + 2] == 0)
                    {
                        maze[x, y + 1] = 1;
                        GenerateMaze(x, y + 2);
                    }
                    break;
                case 4: // Left
                    if (x > 1 && maze[x - 2, y] == 0)
                    {
                        maze[x - 1, y] = 1;
                        GenerateMaze(x - 2, y);
                    }
                    break;
            }
        }
    }

    void DrawMaze()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (maze[x, y] == 1)
                {
                    Instantiate(wallPrefab, new Vector3(x, 0, y), Quaternion.identity);
                }
            }
        }
    }

    void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
