using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_CameraZoom : MonoBehaviour
{
    public float cameraZoomSpeed;
    public Vector3 clamped;

    public Transform player;

    public int minZoomDistance;
    public int maxZoomDistance;

    private void Start()
    {
        clamped.z *= cameraZoomSpeed;
    }

    void Update()
    {
        //makes you zoom in when you scroll forwards.
        if (Vector3.Distance(transform.position, player.position) > minZoomDistance && Input.GetAxis("Mouse ScrollWheel") >= 0)
        {
            transform.Translate(Input.GetAxis("Mouse ScrollWheel") * clamped * Time.deltaTime, Space.Self);
        }

        //makes you zoom out when you scroll backwards.
        if (Vector3.Distance(transform.position, player.position) < maxZoomDistance && Input.GetAxis("Mouse ScrollWheel") <= 0)
        {
            transform.Translate(Input.GetAxis("Mouse ScrollWheel") * clamped * Time.deltaTime, Space.Self);
        }
    }
}