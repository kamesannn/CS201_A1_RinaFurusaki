using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public void OnThis()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Fish);

        if (hasItem == true)    // If player has Fish, player can move the cat
        {
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Fish);
        }

    }
}
