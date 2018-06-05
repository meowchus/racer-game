using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playseleccion : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Application.LoadLevel("carrera");
            SceneManager.LoadScene("carrera");

        }
    }
}
