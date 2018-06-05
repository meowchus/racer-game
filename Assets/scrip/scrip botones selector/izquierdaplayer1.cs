using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izquierdaplayer1 : MonoBehaviour
{
    public GameObject coche1;
    public GameObject coche2;
    public GameObject coche3;
    public GameObject coche4;

    public GameObject elec01;
    public GameObject elec02;
    public GameObject elec03;
    public GameObject elec04;

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

                elec01.SetActive(false);
                elec02.SetActive(false);
                elec03.SetActive(false);
                elec04.SetActive(true);
            }
            else if (coche2.activeSelf)
            {
                coche1.SetActive(true);
                coche2.SetActive(false);
                coche3.SetActive(false);
                coche4.SetActive(false);

                elec01.SetActive(true);
                elec02.SetActive(false);
                elec03.SetActive(false);
                elec04.SetActive(false);
            }
            else if (coche3.activeSelf)
            {
                coche1.SetActive(false);
                coche2.SetActive(true);
                coche3.SetActive(false);
                coche4.SetActive(false);

                elec01.SetActive(false);
                elec02.SetActive(true);
                elec03.SetActive(false);
                elec04.SetActive(false);
            }
            else if (coche4.activeSelf)
            {
                coche1.SetActive(false);
                coche2.SetActive(false);
                coche3.SetActive(true);
                coche4.SetActive(false);

                elec01.SetActive(false);
                elec02.SetActive(false);
                elec03.SetActive(true);
                elec04.SetActive(false);
            }
        }
    }
}
