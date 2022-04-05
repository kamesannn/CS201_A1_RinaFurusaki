using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    public void OnThis()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Wood);

        if (hasItem == true)
        {
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Wood);
        }

    }
}
