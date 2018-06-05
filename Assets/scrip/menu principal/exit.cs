using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) {
            Application.Quit();
            Debug.Log("hasta pronto salio del juego");
        }
    }
}
