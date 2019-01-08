using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preguntas : MonoBehaviour {

    public Canvas canvasPrincipal;
    public Text pregunta, itemA, itemB, itemC, itemD, verificarTxt;

    string puestoControl = "";
    bool verificar = false;
    // Use this for initialization

    private void Awake()
    {
        canvasPrincipal.gameObject.SetActive(false);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(verificar)
        {
            verificarTxt.text = "Correcto";
            verificar = false;
        }
	}

    
    private void OnTriggerEnter(Collider other)
    {
        puestoControl = other.gameObject.name;
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Punto_Control1")
        {
            pregunta.text = "¿Capital de Nariño?";
            itemA.text = "El Tambo";
            itemB.text = "El peñol";
            itemC.text = "Pasto";
            itemD.text = "Ipiales";
        }
        if (other.gameObject.name == "Punto_Control2")
        {
            pregunta.text = "¿Capital de Antioquia?";
            itemA.text = "Medellin";
            itemB.text = "Cali";
            itemC.text = "Pasto";
            itemD.text = "Popayan";
        }
        if (other.gameObject.name == "Punto_Control3")
        {
            pregunta.text = "¿Capital de Cauca?";
            itemA.text = "Armenia";
            itemB.text = "Cajica";
            itemC.text = "Pereira";
            itemD.text = "Popayan";
        }
        canvasPrincipal.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        canvasPrincipal.gameObject.SetActive(false);

    }

    public void VerificarPregunta1(Text item)
    {
        if (puestoControl == "Punto_Control1")
        {
            if (item.text == "Pasto")
            {
                verificar = true;
                Debug.Log("Correcto");
            }
            else
            {
                Debug.Log("InCorrecto");

            }
        }
        if (puestoControl == "Punto_Control2")
        {
            if (item.text == "a) Medellin")
            {
                Debug.Log("Correcto");
            }
            else
            {
                Debug.Log("InCorrecto");

            }
        }
        if (puestoControl == "Punto_Control3")
        {
            if (item.text == "d) Popayan")
            {
                Debug.Log("Correcto");
            }
            else
            {
                Debug.Log("InCorrecto");

            }
        }
    }


}
