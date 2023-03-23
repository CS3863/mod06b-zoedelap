using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f;
    public bool dynamicSpeed = true;

    void Update()
    {
        // increase speed as the game goes on so difficulty is harder
        if (dynamicSpeed) {
            speed += Time.realtimeSinceStartup / 10000;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);        
    }
}
