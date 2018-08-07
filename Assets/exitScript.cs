using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitScript : MonoBehaviour {

    public Button exit;

	// Use this for initialization
	void Start () {
        exit.onClick.AddListener(exitApp);
	}

    void exitApp()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
