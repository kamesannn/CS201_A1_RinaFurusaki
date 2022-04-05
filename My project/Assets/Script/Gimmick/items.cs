using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    public enum Type
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

    public void OnThis()
    {
        Inventory.instance.SetItem(type);
        gameObject.SetActive(false);
        

    }
}
