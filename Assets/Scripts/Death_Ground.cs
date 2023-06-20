using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Ground : MonoBehaviour
{
    public GameObject player;
    public Transform destination;

    void Update()
    {
        {
            if (player.transform.position.y < 90)
            {
                PlayerDied();
            }
        }
    }

    private void PlayerDied()
    {
        Destroy(player.gameObject);
        LevelManager.instance.GameOver();
    }
}
