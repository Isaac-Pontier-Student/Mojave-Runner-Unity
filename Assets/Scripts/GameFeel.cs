using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeel : MonoBehaviour
{
    public static GameFeel instance;
    public float cameraShakeTime = 0.0f;

    void Awake()
    {
        if (instance) //singleton
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public static void AddCameraShake(float time)
    {
        if (instance)
        {
            instance.cameraShakeTime = time; //why cant I just do cameraShakeTime = time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraShakeTime > 0.0f) 
        {
            cameraShakeTime -= Time.deltaTime; //?
            //maybe everything with cameraShakeTime and AddCameraShake(float time) is dictating how long the camera shakes for while the camera shake intensity is dictated below
            Vector3 newCameraPosition = new Vector3();
            newCameraPosition.x = Random.Range(-0.1f, 0.1f);
            newCameraPosition.y = Random.Range(0.23f, 0.43f);
            newCameraPosition.z = -10;
            Camera.main.transform.position = newCameraPosition; //actually accesses the main camera
        }
    }
}
