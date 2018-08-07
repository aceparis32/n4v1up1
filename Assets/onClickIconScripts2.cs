using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickIconScripts2 : MonoBehaviour {

    // public variable
    public GameObject thisGameobject;
    public Text distanceText;

    // private variable
    private double distance;
    private float bearing;

    // Use this for initialization
    void Start()
    {
        Input.location.Start();

        distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
        double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[1];
        double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[1];
        double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
        double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
        bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
        thisGameobject.transform.Rotate(0, bearing, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        distanceText.text = "Derajat kompas : " + bearing.ToString() + " m";
    }

    float getBearing(double latTarget, double lonTarget, double latPlayer, double lonPlayer)
    {
        var radians = Math.Atan2((lonTarget - lonPlayer), (latTarget - latPlayer));
        var compassBearing = radians * (180 / Math.PI);
        var convCompass = Convert.ToSingle(compassBearing);

        return convCompass;
    }
}
