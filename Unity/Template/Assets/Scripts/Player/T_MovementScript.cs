using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_MovementScript : MonoBehaviour
{
    public GameObject characterCam;
    private Vector3 cameraRotate;
    public float cameraRotateSpeed;

    private Vector3 movement;
    public float movementSpeed;

    void Start()
    {
        cameraRotate.y = cameraRotateSpeed;
    }

    void Update()
    {
        //rotates the camera when pressing Q or E.
        if (Input.GetButton("Q") == true && Input.GetButton("E") == false)
        {
            transform.Rotate(-cameraRotate * Time.deltaTime);
        }
        if (Input.GetButton("E") == true && Input.GetButton("Q") == false)
        {
            transform.Rotate(cameraRotate * Time.deltaTime);
        }

        //moves the character using wasd.
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.Self);
    }
}