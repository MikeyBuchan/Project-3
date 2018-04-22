using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_DownBox : MonoBehaviour 
{
    public GameObject player;
    public Vector3 respawnLoc;

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            player.transform.position = respawnLoc;
        }
        else if (c.gameObject.tag == "Enemy")
        {
            //GameObject.FindGameObjectWithTag
        }
    }
}
