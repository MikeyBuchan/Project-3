using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_WindPush : MonoBehaviour 
{
    public float timeBetweenShot;
    public GameObject bullet;
    public float bulletSpeed;
    public GameObject barrel;
    public bool bol;
	

	void Update () 
	{
        if (!bol)
        {
            StartCoroutine(WindShoot());
        }
	}

    public IEnumerator WindShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject g = Instantiate(bullet, barrel.transform.position,barrel.transform.rotation);
            Rigidbody rb = g.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            Destroy(g, 3);
            bol = true;
            yield return new WaitForSeconds(timeBetweenShot);
            bol = false;
        }
    }
}