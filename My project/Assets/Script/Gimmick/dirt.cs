using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour
{
    public void OnThis()
    {
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Cloth);

        if (hasItem == true)
        {
            gameObject.SetActive(false);
            Inventory.instance.UseItem(items.Type.Cloth);
        }

    }
}
