using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax
{
    public enum Layer
    {
        Foreground, Midground, Background
    }
    public static float speed = 3f;

    public static float GetSpeed(Layer layer)
    {
        switch (layer)
        {
            case Layer.Foreground:
                return speed * 1;
            case Layer.Midground:
                return speed * 0.5f;
            case Layer.Background:
                return speed * 0.1f;
            default:
                return speed * 1;
        }
    }
}

public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;

    public float left = -19f;
    public Vector3 right = new Vector3(19f, 0f, 0f);
    //gameobject.transform.position.y references the y position of this object

    //if there's a problem with Y alignment, change Vector3 right into another float and only change the position.x

    public Parallax.Layer layer;

    void Update()
    {
        for (int i = 0; i < tiles.Length; i++) //used to mess with each tile on the layer (the array tiles that contains all the layer sprites)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.GetSpeed(layer);

            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
