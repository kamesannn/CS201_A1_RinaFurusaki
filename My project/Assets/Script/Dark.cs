using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class Dark : MonoBehaviour
{

    void Start()
    {
        DOVirtual.DelayedCall(7, GoToNext);

    }

    // Update is called once per frame
    public void GoToNext()
    {
        SceneManager.LoadScene("Game");
    }
}
