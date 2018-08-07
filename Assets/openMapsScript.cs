using UnityEngine;
//using UnityEditor;
using System;
using UnityEngine.UI;

public class openMapsScript : MonoBehaviour {
    
    private double latForMaps;
    private double lonForMaps;
    public Text getLat;
    public Text getLon;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        
    }

    private void OnMouseDown()
    {
        //#if UNITY_EDITOR
        //bool decide = EditorUtility.DisplayDialog("Apakah anda ingin membuka Google Maps?", "Ya", "Tidak");
        //#endif
        //if (decide)
        //{
            latForMaps = Convert.ToDouble(getLat.text);
            lonForMaps = Convert.ToDouble(getLon.text);
            Application.OpenURL("http://maps.google.com/maps?q=" + latForMaps + "," + lonForMaps);
        //}
    }
}
