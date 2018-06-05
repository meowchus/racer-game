using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Application.LoadLevel("selector de coche");
            SceneManager.LoadScene("selector de coche");
            
        }
    }
}
