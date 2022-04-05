using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    
    public void OnThisWood()
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

        if (hasItem == true)
        {
            AudioManager.instance.Play("Match");
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Matchbox);
        }

    }
}
