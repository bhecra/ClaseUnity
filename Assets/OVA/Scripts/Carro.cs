using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour {


    public float speed = 0.2f;
    public int llantas = 4;
    public int puertas = 5;
    public float gasolina = 5.5f;
    public bool electrico = false;
    public string color = "rojo";
    public string marca = "mazda";

    public Carro(string marca, int puertas)
    {
        marca = this.marca;
        puertas = this.puertas;
    }
    public Carro()
    {
        marca = "";
        puertas = 0;
        color = "gris";
    }
    // Use this for initialization
    void Start () {

        Carro mazda = new Carro("mazda", 5);
        Carro nuevo = new Carro();
        Debug.Log("Carro Mazda: ");
        Debug.Log(mazda.marca);
        Debug.Log("Carro Nuevo: ");
        Debug.Log(nuevo.marca);
        Enecender();
	}
	
	// Update is called once per frame
	void Update () {

        /*if (electrico)
        {
            Debug.Log(marca);
        }*/

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Arracar();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GirarDerecha();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GirarIzquierda();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Frenar();
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Reversa();
        }
    }

    void Arracar()
    {
        Debug.Log("Arranque");
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        this.transform.Rotate(new Vector3(0,40,0) * Time.deltaTime, Space.World);

    }

    void Enecender()
    {
        Debug.Log("Ruuun");
    }

    void Frenar()
    {
        Debug.Log("Frene");
    }
    void GirarDerecha()
    {
        Debug.Log("Gire derecha");
        this.transform.Translate(new Vector3(1,0,0), Space.World);

    }

    void GirarIzquierda()
    {
        Debug.Log("Gire izquierda");
        this.transform.Translate(-new Vector3(1, 0, 0), Space.World);

    }

    void Reversa()
    {
        Debug.Log("Reversa");
        this.transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed, Space.World);
    }
}
