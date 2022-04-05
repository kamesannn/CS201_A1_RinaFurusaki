using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainRoomSceneChange : MonoBehaviour
{
    
    public void changeRoom(string roomName)
    {
        SceneManager.LoadScene(roomName);
    }
}
