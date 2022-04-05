using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;
using UnityEngine.SceneManagement;


public class beforeStart : MonoBehaviour
{
    
 
    public void GoToNext()
    {
        SceneManager.LoadScene("Dark");
    }
}
