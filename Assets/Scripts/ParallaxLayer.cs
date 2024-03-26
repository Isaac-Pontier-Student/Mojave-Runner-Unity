using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax
{
    public static float speed = 2f;
}

public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;

    public float left = -19f;
    public Vector3 right = new Vector3(19f, 0f, 0f);

    public float rate = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.speed * rate;

            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
