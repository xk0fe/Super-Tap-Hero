using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevitation : MonoBehaviour
{
    public float power = .5f;

    void Update()
    {
        float reality = power / 2;
        transform.position = new Vector2 (transform.position.x, transform.position.y + (Mathf.PingPong(Time.time, power) - reality));
    }
}
