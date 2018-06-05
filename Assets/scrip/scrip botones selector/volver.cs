using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Application.LoadLevel("menu pricipal");
            print("start game");
            SceneManager.LoadScene("menu pricipal");
            Destroy(DontDestroyOnLoad);

        }
    }

    private void Destroy(Action<UnityEngine.Object> dontDestroyOnLoad)
    {
        throw new NotImplementedException();
    }
}