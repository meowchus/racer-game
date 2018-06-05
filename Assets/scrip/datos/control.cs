using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
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

    void fixedupdate()
    {
        elec01 = GameObject.FindGameObjectWithTag("elec01");
        elec02 = GameObject.FindGameObjectWithTag("elec02");
        elec03 = GameObject.FindGameObjectWithTag("elec03");
        elec04 = GameObject.FindGameObjectWithTag("elec04");
    }
}
