using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloon : MonoBehaviour
{
    public void OnThis()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Needle);

        if (hasItem == true)    // If player has Needle, player can pop Ballon
        {
            AudioManager.instance.Play("Ballon");
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Needle);
        }
    }

}