using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control1 : MonoBehaviour {

    public GameObject coche1;
    public GameObject coche2;
    public GameObject coche3;
    public GameObject coche4;

    public GameObject elec01;
    public GameObject elec02;
    public GameObject elec03;
    public GameObject elec04;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {

        elec01 = GameObject.FindGameObjectWithTag("elec01");
        elec02 = GameObject.FindGameObjectWithTag("elec02");
        elec03 = GameObject.FindGameObjectWithTag("elec03");
        elec04 = GameObject.FindGameObjectWithTag("elec04");

        if (elec01==true) {
            coche1.SetActive(true);
        }
        if (elec02 == true)
        {
            coche2.SetActive(true);
        }
        if (elec03 == true)
        {
            coche3.SetActive(true);
        }
        if (elec04 == true)
        {
            coche4.SetActive(true);
        }

        
    }
}
