using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T_ShopScript : MonoBehaviour
{
    public GameObject shopUI;

    public GameObject player;
    public T_Inventory inventory;
    public GameObject shopCamera;
    public float shopRange;

    private bool inShop = false;
    public GameObject nearShopText;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<T_Inventory>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= shopRange)
        {
            nearShopText.SetActive(true);

            if (Input.GetButtonDown("Use") == true && inShop == false)
            {
                shopCamera.SetActive(true);
                player.SetActive(false);
                inShop = true;
                shopUI.SetActive(true);

                nearShopText.GetComponent<Text>().text = "Press F to exit shop";
            }
            else if (Input.GetButtonDown("Use") == true && inShop == true)
            {
                player.SetActive(true);
                shopCamera.SetActive(false);
                inShop = false;
                shopUI.SetActive(false);

                nearShopText.GetComponent<Text>().text = "Press F to enter shop";
            }
        }
        else if (Vector3.Distance(transform.position, player.transform.position) > shopRange)
        {
            nearShopText.SetActive(false);
        }
    }

    public void BuyBombTower()
    {
        inventory.bombTowers += 1;
        inventory.bombUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().bombTowers.ToString();
    }
    public void BuySniperTower()
    {
        inventory.sniperTowers += 1;
        inventory.sniperUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().sniperTowers.ToString();
    }
    public void BuyMachineGunTower()
    {
        inventory.machinegunTowers += 1;
        inventory.machinegunUI.GetComponent<Text>().text = player.GetComponent<T_Inventory>().machinegunTowers.ToString();
    }
}
