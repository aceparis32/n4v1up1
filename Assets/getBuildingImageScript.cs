using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getBuildingImageScript : MonoBehaviour {

    private int idBuildingImage;
    private Sprite imageSprite;
    public GameObject imageGameObject;
    public Text getIdBuildingImage;

	// Use this for initialization
	void Start () {
        
	}

    private void OnEnable()
    {
        idBuildingImage = Convert.ToInt32(getIdBuildingImage.text);
        imageSprite = GameObject.Find("Canvas").GetComponent<databaseScript>().buildingImage[idBuildingImage];

        imageGameObject.GetComponent<SpriteRenderer>().sprite = imageSprite;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
