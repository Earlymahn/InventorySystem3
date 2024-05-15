using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[10, 10];
    public float coins;
    public Text CoinsTXT;




    void Start()
    {
        CoinsTXT.text = "Coins:" + coins.ToString();
        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 50;
        shopItems[2, 6] = 60;
        shopItems[2, 7] = 70;
        shopItems[2, 8] = 80;
        shopItems[2, 9] = 90;
        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0;
        shopItems[3, 9] = 0;
       


    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        int itemID = ButtonRef.GetComponent<ButtonInfo>().ItemID;
        int itemPrice = shopItems[2, itemID];

        // Check if the player has enough coins to buy the item
        if (coins >= itemPrice && itemPrice > 0) // Ensure the item has a non-zero price
        {
            coins -= itemPrice;
            shopItems[2, itemID]++;
            CoinsTXT.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[2, itemID].ToString();
        }
        else
        {
            // Optionally, you can display a message to the player indicating they don't have enough coins.
            Debug.Log("You don't have enough coins to buy this item!");
        }
    }
}
