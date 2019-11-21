using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
    Vector3 pos;

    void Update()
    {

        if (player.position.y <= -33)
        {
            transform.position = new Vector3(player.position.x, -33, -10);
            if (player.position.x <= -422)
                transform.position = new Vector3(-422, -33, -10);
            if (player.position.x >= 872)
                transform.position = new Vector3(872, -33, -10);
        }

        if (player.position.y >= 254)
        {
            transform.position = new Vector3(player.position.x, 254, -10);
            if (player.position.x <= -422)
                transform.position = new Vector3(-422, 254, -10);
            if (player.position.x >= 872)
                transform.position = new Vector3(872, 254, -10);
        }
        if (player.position.x <= -422)
        {
            transform.position = new Vector3(-422, player.position.y, -10);
            if (player.position.y <= -33)
                transform.position = new Vector3(-422, -33, -10);
            if (player.position.y >= 254)
                transform.position = new Vector3(-422, 254, -10);
        }
        if (player.position.x >= 872)
        {
            transform.position = new Vector3(872, player.position.y, -10);
            if (player.position.y <= -33)
                transform.position = new Vector3(872, -33, -10);
            if (player.position.y >= 254)
                transform.position = new Vector3(872, 254, -10);
        }



    }

}
