using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control2 : MonoBehaviour {
    public GameObject coche5;
    public GameObject coche6;
    public GameObject coche7;
    public GameObject coche8;

    public GameObject elec05;
    public GameObject elec06;
    public GameObject elec07;
    public GameObject elec08;


    // Use this for initialization
    void Start()
    {

    }

    void Update ()
    {
        elec05 = GameObject.FindGameObjectWithTag("elec05");
        elec06 = GameObject.FindGameObjectWithTag("elec06");
        elec07 = GameObject.FindGameObjectWithTag("elec07");
        elec08 = GameObject.FindGameObjectWithTag("elec08");

        if (elec05 == true)
        {
            coche5.SetActive(true);
        }
        if (elec06 == true)
        {
            coche6.SetActive(true);
        }
        if (elec07 == true)
        {
            coche7.SetActive(true);
        }
        if (elec08 == true)
        {
            coche8.SetActive(true);
        }

    }
}
