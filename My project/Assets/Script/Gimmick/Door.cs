using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject DoorOpenImage;
    public void UnlockDoor()
    {
        
        bool hasItem = Inventory.instance.CanUseItem(items.Type.Key);

        if (hasItem == true)
        {
            AudioManager.instance.Play("DoorUnlock");
            DoorOpenImage.SetActive(true);
            Inventory.instance.UseItem(items.Type.Key);
        }

    }
    public void ExitFormRoom()
    {
        SceneManager.LoadScene("ExitRoom");
    }
}
