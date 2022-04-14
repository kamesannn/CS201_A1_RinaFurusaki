using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    public enum Type    // All the items which player can use are here
    {
        Cloth,
        Key,
        Wood,
        Matchbox,
        Fish,
        Needle,
        Water,
        Key3,
    }

    public Type type;

    public void OnThis()    // If player use an item, the item in the inventory will be disappear
    {
        Inventory.instance.SetItem(type);
        gameObject.SetActive(false);
        

    }
}
