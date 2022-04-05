using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject box0;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    public GameObject box7;

    public GameObject selected0;
    public GameObject selected1;
    public GameObject selected2;
    public GameObject selected3;
    public GameObject selected4;
    public GameObject selected5;
    public GameObject selected6;
    public GameObject selected7;

    //public GameObject[] selects;

    public static Inventory instance;
    private void Awake()
    {
        instance = this;
    }


    public void SetItem(items.Type type)
    {
        if (type == items.Type.Cloth)
        {
            box0.SetActive(true);
        }
        else if (type == items.Type.Matchbox)
        {
            box1.SetActive(true);
        }
        else if (type == items.Type.Wood)
        {
            box2.SetActive(true);
        }
        else if (type == items.Type.Fish)
        {
            box3.SetActive(true);
        }
        else if (type == items.Type.Needle)
        {
            box4.SetActive(true);
        }
        else if (type == items.Type.Key)
        {
            box5.SetActive(true);
        }
        else if (type == items.Type.Key2)
        {
            box6.SetActive(true);
        }
        else if (type == items.Type.Key3)
        {
            box7.SetActive(true);
        }
    }

    public bool CanUseItem(items.Type type)
    {
        if (type == items.Type.Cloth)
        {
            return box0.activeSelf;
        }
        if (type == items.Type.Fish)
        {
            return box3.activeSelf;
        }
        if (type == items.Type.Needle)
        {
            return box4.activeSelf;
        }

        return false;
    }

    public void UseItem(items.Type type)
    {
        if (type == items.Type.Cloth)
        {
            box0.SetActive(false);
        }
        else if (type == items.Type.Matchbox)
        {
            box1.SetActive(false);
        }
        else if (type == items.Type.Wood)
        {
            box2.SetActive(false);
        }
        else if (type == items.Type.Fish)
        {
            box3.SetActive(false);
        }
        else if (type == items.Type.Needle)
        {
            box4.SetActive(false);
        }
        else if (type == items.Type.Key)
        {
            box5.SetActive(false);
        }
    }

    public void SelectItem()
    {
        GameObject[] selects = GameObject.FindGameObjectsWithTag("selectedTag");
        Debug.Log(selects.Length);
        foreach(GameObject select in selects)
        {
            select.SetActive(false);
        }

        if (box0.activeSelf)
        {
            selected0.SetActive(true);
        }
        else if (box1.activeSelf)
        {
            selected1.SetActive(true);
        }
        else if (box2.activeSelf)
        {
            selected2.SetActive(true);
        }
        else if (box3.activeSelf)
        {
            selected3.SetActive(true);
        }
        else if (box4.activeSelf)
        {
            selected4.SetActive(true);
        }
        else if (box5.activeSelf)
        {
            selected5.SetActive(true);
        }
        else if (box6.activeSelf)
        {
            selected6.SetActive(true);
        }
        else if (box7.activeSelf)
        {
            selected7.SetActive(true);
        }
    }

}
