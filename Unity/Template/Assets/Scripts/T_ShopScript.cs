using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T_ShopScript : MonoBehaviour
{
    public GameObject shopUI;

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
                shopUI.SetActive(true);

                nearShopText.GetComponent<Text>().text = "Press space to exit shop";
            }         
            else if(Input.GetButtonDown("Jump") == true && inShop == true)
            {
                player.SetActive(true);
                shopCamera.SetActive(false);
                inShop = false;
                shopUI.SetActive(false);

                nearShopText.GetComponent<Text>().text = "Press space to enter shop";
            }
        }
        else if(Vector3.Distance(transform.position, player.transform.position) > shopRange)
        {
            nearShopText.SetActive(false);
        }
	}

    public void BuyBombTower ()
    {
        player.GetComponent<T_Inventory>().bombTowers += 1;
        player.GetComponent<T_Inventory>().bombUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().bombTowers.ToString();
    }
    public void BuySniperTower()
    {
        player.GetComponent<T_Inventory>().sniperTowers += 1;
        player.GetComponent<T_Inventory>().sniperUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().sniperTowers.ToString();
    }
    public void BuyMachineGunTower()
    {
        player.GetComponent<T_Inventory>().machinegunTowers += 1;
        player.GetComponent<T_Inventory>().machinegunUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().machinegunTowers.ToString();
    }
}
