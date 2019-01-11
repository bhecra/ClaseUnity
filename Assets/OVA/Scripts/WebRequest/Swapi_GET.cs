using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class Swapi_GET : MonoBehaviour {

    public InputField url;
    public Text response;

    private string filmsTxt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator GetPeople()
    {
        UnityWebRequest www = UnityWebRequest.Get(url.text);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }else
        {
            JSONNode datos = JSON.Parse(www.downloadHandler.text);
            Debug.Log(www.downloadHandler.text.GetType());
            //response.text = www.downloadHandler.text;

            for (int i=0; i <= 2; i++ )
            {
                filmsTxt += datos["films"][i] + "\n";
            }
            //response.text = (datos["films"][0]);
            
            response.text = filmsTxt;
            
        }
    }

    public void SendRequest()
    {
        StartCoroutine(GetPeople());
    }
}
