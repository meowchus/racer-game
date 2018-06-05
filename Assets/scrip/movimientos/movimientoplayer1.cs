using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movimientoplayer1 : MonoBehaviour {
    public GameObject jugador1;
    public GameObject jugador2;
    public Text marcador1;
    public Text marcador2;
    int contador1;
    int contador2;
    bool final;

    void start()
    {
        contador1 = 0;
        contador2 = 0;
        final = false;
    }
    void Update () {

        if (!final)
        {
            if (contador1 == 150)
            {
                marcador1.text = "Has ganado";
                final = true;
            }
            else if (Input.GetKeyDown(KeyCode.F1))
            {
                jugador1.transform.Translate(9.91f, 0, 0);
                contador1++;
                marcador1.text = "" + contador1;
            }

            if (contador2 == 150)
            {
                marcador2.text = "Has ganado";
                final = true;
            }
            else if (Input.GetKeyDown(KeyCode.F2))
            {
                jugador2.transform.Translate(9.91f, 0, 0);
                contador2++;
                marcador2.text = "" + contador2;
            }

        }
	}

}
