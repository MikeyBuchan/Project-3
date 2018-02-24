using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T_ShopScript : MonoBehaviour
{
    public GameObject player;
    public GameObject shopCamera;
    public float shopRange;

    private bool inShop = false;
    public GameObject nearShopText;

	void Start () 
	{
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () 
	{
		if(Vector3.Distance(transform.position,player.transform.position) <= shopRange)
        {
            nearShopText.SetActive(true);

            if(Input.GetButtonDown("Jump") == true && inShop == false)
            {
                shopCamera.SetActive(true);
                player.SetActive(false);
                inShop = true;

                nearShopText.GetComponent<Text>().text = "Press space to exit shop";
            }         
            else if(Input.GetButtonDown("Jump") == true && inShop == true)
            {
                player.SetActive(true);
                shopCamera.SetActive(false);
                inShop = false;

                nearShopText.GetComponent<Text>().text = "Press space to enter shop";
            }
        }
        else if(Vector3.Distance(transform.position, player.transform.position) > shopRange)
        {
            nearShopText.SetActive(false);
        }
	}
}
