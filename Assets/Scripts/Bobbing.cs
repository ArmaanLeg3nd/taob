using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour
{
    public GameObject shape;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        shape.transform.position = new Vector3(-28, 102+y, -4);
    }
}