using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flower : MonoBehaviour
{
    public Image smallFlower;
    public Sprite bigFlower;


    public void ChangeFlowerSize()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Water);

        if (hasItem == true)    // If player has water and click the small flower it will be change to bigFlower with the sound effect
        {
            smallFlower.sprite = bigFlower;
            AudioManager.instance.Play("Shine");
            Inventory.instance.UseItem(items.Type.Water);
        }
        
    }
}
