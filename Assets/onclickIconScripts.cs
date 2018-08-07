using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;

public class onclickIconScripts : MonoBehaviour {

    // public variable
    public GameObject[] pic3D;
    public GameObject thisGameobject;
    public Text distanceText;
    public GameObject dropdownJurusan;
    public Text idFacultyText;
    public Text idBuildingImage;
    public Text lonText;
    public Text latText;
    public TextMesh depInfo;
    public Text facultyInfo;

    public int convDistance;
    public int[] idCategory;
    public double[] lonData;
    public double[] latData;

    // private variable
    private double distance;
    private float bearing;

    // Use this for initialization
    void Start()
    {
        if (thisGameobject.name == "locIcon")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[0];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[0];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon1")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[1];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[1];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon2")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[2];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[2];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);

        }
        else if (thisGameobject.name == "locIcon3")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[3];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[3];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon4")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[4];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[4];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon5")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[5];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[5];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon6")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[6];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[6];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon7")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[7];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[7];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon8")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[8];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[8];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon9")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[9];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[9];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon10")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[10];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[10];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon11")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[11];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[11];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon12")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[12];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[12];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon13")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[13];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[13];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon14")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[14];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[14];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon15")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[15];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[15];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon16")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[16];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[16];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon17")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[17];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[17];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon18")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[18];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[18];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon19")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[19];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[19];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon20")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[20];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[20];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon21")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[21];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[21];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon22")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[22];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[22];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon23")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[23];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[23];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon24")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[24];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[24];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon25")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[25];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[25];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon26")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[26];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[26];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon27")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[27];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[27];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon28")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[28];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[28];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon29")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[29];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[29];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon30")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[30];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[30];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon31")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[31];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[31];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon32")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[32];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[32];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon33")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[33];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[33];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon34")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[34];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[34];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon35")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[35];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[35];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon36")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[36];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[36];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon37")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[37];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[37];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;

            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon38")
        {
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[38];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[38];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;

            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            distance = getDistance(latPlayer, lonPlayer, latTarget, lonTarget);
            thisGameobject.transform.rotation = Quaternion.Euler(0, bearing, 0);
        }

        // convert distance to int
        convDistance = Convert.ToInt32(distance);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (thisGameobject.name == "locIcon")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[0].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[0].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[0].ToString("G");
            idBuildingImage.text = "0";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon1")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[1].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[1].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[1].ToString("G");
            idBuildingImage.text = "1";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon2")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[2].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[2].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[2].ToString("G");
            idBuildingImage.text = "2";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 1;
        }
        else if (thisGameobject.name == "locIcon3")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[3].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[3].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[3].ToString("G");
            idBuildingImage.text = "3";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon4")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[4].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[4].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[4].ToString("G");
            idBuildingImage.text = "4";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon5")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[5].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[5].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[5].ToString("G");
            idBuildingImage.text = "5";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon6")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[6].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[6].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[6].ToString("G");
            idBuildingImage.text = "6";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon7")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[7].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[7].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[7].ToString("G");
            idBuildingImage.text = "7";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon8")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[8].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[8].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[8].ToString("G");
            idBuildingImage.text = "8";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon9")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[9].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[9].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[9].ToString("G");
            idBuildingImage.text = "9";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon10")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[10].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[10].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[10].ToString("G");
            idBuildingImage.text = "10";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon11")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[11].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[11].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[11].ToString("G");
            idBuildingImage.text = "11";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon12")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[12].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[12].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[12].ToString("G");
            idBuildingImage.text = "12";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon13")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[13].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[13].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[13].ToString("G");
            idBuildingImage.text = "13";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon14")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[14].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[14].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[14].ToString("G");
            idBuildingImage.text = "14";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon15")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fakultas";
            depInfo.text = "";
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[15].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[15].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[15].ToString("G");
            idBuildingImage.text = "15";
            pic3D[0].SetActive(true);
            pic3D[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[0].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon16")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().idCategoryData[16].ToString();
            latText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().latData[16].ToString("G");
            lonText.text = GameObject.Find("Canvas").GetComponent<databaseScript>().lonData[16].ToString("G");
            idBuildingImage.text = "16";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon17")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[17].ToString();
            latText.text = latData[17].ToString("G");
            lonText.text = lonData[17].ToString("G");
            idBuildingImage.text = "17";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);

        }
        else if (thisGameobject.name == "locIcon18")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);

            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[18].ToString();
            latText.text = latData[18].ToString("G");
            lonText.text = lonData[18].ToString("G");
            idBuildingImage.text = "18";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon19")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[18].ToString();
            latText.text = latData[19].ToString("G");
            lonText.text = lonData[19].ToString("G");
            idBuildingImage.text = "19";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);

        }
        else if (thisGameobject.name == "locIcon20")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[20].ToString();
            latText.text = latData[20].ToString("G");
            lonText.text = lonData[20].ToString("G");
            idBuildingImage.text = "20";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon21")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[21].ToString();
            latText.text = latData[21].ToString("G");
            lonText.text = lonData[21].ToString("G");
            idBuildingImage.text = "21";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon22")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[22].ToString();
            latText.text = latData[22].ToString("G");
            lonText.text = lonData[22].ToString("G");
            idBuildingImage.text = "22";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon23")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[23].ToString();
            latText.text = latData[23].ToString("G");
            lonText.text = lonData[23].ToString("G");
            idBuildingImage.text = "23";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon24")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[24].ToString();
            latText.text = latData[24].ToString("G");
            lonText.text = lonData[24].ToString("G");
            idBuildingImage.text = "24";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon25")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[25].ToString();
            latText.text = latData[25].ToString("G");
            lonText.text = lonData[25].ToString("G");
            idBuildingImage.text = "25";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon26")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[26].ToString();
            latText.text = latData[26].ToString("G");
            lonText.text = lonData[26].ToString("G");
            idBuildingImage.text = "26";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon27")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[27].ToString();
            latText.text = latData[27].ToString("G");
            lonText.text = lonData[27].ToString("G");
            idBuildingImage.text = "27";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon28")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[28].ToString();
            latText.text = latData[28].ToString("G");
            lonText.text = lonData[28].ToString("G");
            idBuildingImage.text = "28";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon29")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[29].ToString();
            latText.text = latData[29].ToString("G");
            lonText.text = lonData[29].ToString("G");
            idBuildingImage.text = "29";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon30")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[30].ToString();
            latText.text = latData[30].ToString("G");
            lonText.text = lonData[30].ToString("G");
            idBuildingImage.text = "30";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon31")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[31].ToString();
            latText.text = latData[31].ToString("G");
            lonText.text = lonData[31].ToString("G");
            idBuildingImage.text = "31";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon32")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[32].ToString();
            latText.text = latData[32].ToString("G");
            lonText.text = lonData[32].ToString("G");
            idBuildingImage.text = "32";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon33")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[33].ToString();
            latText.text = latData[33].ToString("G");
            lonText.text = lonData[33].ToString("G");
            idBuildingImage.text = "33";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon34")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[34].ToString();
            latText.text = latData[34].ToString("G");
            lonText.text = lonData[34].ToString("G");
            idBuildingImage.text = "34";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon35")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[35].ToString();
            latText.text = latData[35].ToString("G");
            lonText.text = lonData[35].ToString("G");
            idBuildingImage.text = "35";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon36")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[36].ToString();
            latText.text = latData[36].ToString("G");
            lonText.text = lonData[36].ToString("G");
            idBuildingImage.text = "36";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon37")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[37].ToString();
            latText.text = latData[37].ToString("G");
            lonText.text = lonData[37].ToString("G");
            idBuildingImage.text = "37";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon38")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);


            facultyInfo.text = "Deskripsi Fasilitas";
            dropdownJurusan.SetActive(false);
            distanceText.text = "Jarak : " + convDistance.ToString() + " m";
            idFacultyText.text = idCategory[38].ToString();
            latText.text = latData[38].ToString("G");
            lonText.text = lonData[38].ToString("G");
            idBuildingImage.text = "38";
            pic3D[1].SetActive(true);
            pic3D[1].transform.rotation = Quaternion.Euler(0, 0, 0);
            pic3D[1].transform.rotation = Quaternion.Euler(0, bearing, 0);
        }

        //distanceText.text = bearing.ToString();
    }

    float getBearing(double latTarget, double lonTarget, double latPlayer, double lonPlayer)
    {
        var radians = Math.Atan2((lonTarget - lonPlayer), (latTarget - latPlayer));
        var compassBearing = radians * (180 / Math.PI);
        var convCompass = Convert.ToSingle(compassBearing);

        return convCompass;
    }

    double getDistance(double latPlayer, double lonPlayer, double latTarget, double lonTarget)
    {
        var R = 6371.137; // Radius of the earth in km
                          // latTarget - latPlayer
        var dLat = latPlayer * Math.PI / 180 - latTarget * Math.PI / 180;
        var dLon = lonPlayer * Math.PI / 180 - lonTarget * Math.PI / 180;
        var a =
          Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
          Math.Cos(latTarget * Math.PI / 180) * Math.Cos(latPlayer * Math.PI / 180) *
          Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
          ;
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        var d = (R * c) * 1000f; // Distance in m
        return d;
    }

    double deg2rad(double deg)
    {
        return deg * (Math.PI / 180);
    }

}
