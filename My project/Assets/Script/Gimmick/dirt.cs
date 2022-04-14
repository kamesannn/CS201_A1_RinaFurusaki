using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour
{
    public void OnThis()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Cloth);

        if (hasItem == true)    // If player has Cloth, player can clean Dirt, and the sound effect will be played
        {
            AudioManager.instance.Play("Wipe");
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Cloth);
        }

    }
}
