using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contenedores : MonoBehaviour {

    public int[] edad = new int[10];
    public GameObject[] cubos = new GameObject[10];

    public List<string> nombres = new List<string>();
    ArrayList personas = new ArrayList();
    Hashtable carros = new Hashtable();

	// Use this for initialization
	void Start () {

        cubos = GameObject.FindGameObjectsWithTag("Cubo");

        /*for(int i = 0; i< edad.Length; i++)
        {
            edad[i] = i; 
            Debug.Log(edad[i]);
        }*/

        nombres.Add("Frank");
        nombres.Add("Christian");

        personas.Add(18);
        personas.Add("Camilo");
        personas.Add(1.74);
    


        /*for (int i = 0; i < edad.Length; i++)
        {
            Debug.Log(personas[i]);
        }*/
 
        /*foreach(string nombre in nombres)
        {
            Debug.Log(nombre);
        }*/

        carros.Add("llantas", 4);
        carros.Add("marca", "mazda");

        Debug.Log(carros["llantas"]);
        Debug.Log(carros["marca"]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
