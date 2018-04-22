using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PlayerMovement : MonoBehaviour
{
    private Vector3 pos;
    public float speed;


    void FixedUpdate()
    {
        pos.x = Input.GetAxis("Horizontal");
        pos.z = Input.GetAxis("Vertical");
        transform.Translate(pos * Time.deltaTime * speed, Space.World);
        transform.LookAt(new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, Camera.main.ScreenToWorldPoint(Input.mousePosition).z));
    }
}

