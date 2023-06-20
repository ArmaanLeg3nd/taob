using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform Bullet;
    public Transform Spawn;
    public AudioSource Shot;
    //Gun Stuff
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Vector3 aimPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        aimPos.z = 0;
        aimPos.x = 0;

        //Creating the bullet and shooting it
        var pel = Instantiate(Bullet, Spawn.position, Spawn.rotation);
        pel.GetComponent<Rigidbody2D>().AddForce(aimPos.normalized * 8000f);
        //Playing the bullet noise
        Shot.Play();
        //shooting and reloading
    }
}
