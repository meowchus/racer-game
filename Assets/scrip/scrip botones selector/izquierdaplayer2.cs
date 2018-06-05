using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izquierdaplayer2 : MonoBehaviour
{
    public GameObject coche1;
    public GameObject coche2;
    public GameObject coche3;
    public GameObject coche4;

    public GameObject elec05;
    public GameObject elec06;
    public GameObject elec07;
    public GameObject elec08;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (coche1.activeSelf)
            {
                coche1.SetActive(false);
                coche2.SetActive(false);
                coche3.SetActive(false);
                coche4.SetActive(true);

                elec05.SetActive(false);
                elec06.SetActive(false);
                elec07.SetActive(false);
                elec08.SetActive(true);
            }
            else if (coche2.activeSelf)
            {
                coche1.SetActive(true);
                coche2.SetActive(false);
                coche3.SetActive(false);
                coche4.SetActive(false);

                elec05.SetActive(true);
                elec06.SetActive(false);
                elec07.SetActive(false);
                elec08.SetActive(false);
            }
            else if (coche3.activeSelf)
            {
                coche1.SetActive(false);
                coche2.SetActive(true);
                coche3.SetActive(false);
                coche4.SetActive(false);

                elec05.SetActive(false);
                elec06.SetActive(true);
                elec07.SetActive(false);
                elec08.SetActive(false);
            }
            else if (coche4.activeSelf)
            {
                coche1.SetActive(false);
                coche2.SetActive(false);
                coche3.SetActive(true);
                coche4.SetActive(false);

                elec05.SetActive(false);
                elec06.SetActive(false);
                elec07.SetActive(true);
                elec08.SetActive(false);
            }
        }
    }
}