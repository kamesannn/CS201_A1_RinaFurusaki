using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    
    public void OnThisWood()    // Place wood into the fireplace
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Wood);

        if (hasItem == true)
        {
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Wood);
        }

    }

    public void OnThisFire()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Matchbox);

        if (hasItem == true)    // If player has Matchbox, the fireplace will be completed, and play the sound effect
        {
            AudioManager.instance.Play("Match");
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Matchbox);
        }

    }
}
