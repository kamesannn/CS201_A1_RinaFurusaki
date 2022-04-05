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

        if (hasItem == true)
        {
            smallFlower.sprite = bigFlower;
            AudioManager.instance.Play("Shine");
            Inventory.instance.UseItem(items.Type.Water);
        }
        
    }
}
