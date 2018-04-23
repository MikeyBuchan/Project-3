using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T_Inventory : MonoBehaviour
{
    public int health;
    public int funds;

    public int bombTowers;
    public int sniperTowers;
    public int machinegunTowers;

    public GameObject bombUI;
    public GameObject sniperUI;
    public GameObject machinegunUI;

    void Start()
    {
        
    }

    void Update()
    {
        bombUI.GetComponent<Text>().text = bombTowers.ToString();
        sniperUI.GetComponent<Text>().text = sniperTowers.ToString();
        machinegunUI.GetComponent<Text>().text = machinegunTowers.ToString();
    }
}
