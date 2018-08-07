using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickIconScripts3 : MonoBehaviour {

    // public variable
    public GameObject[] pic3D;
    public GameObject thisGameobject;
    public GameObject arInfo;
    public Text distanceText;

    // private variable
    private double distance;
    private float bearing;

    // Use this for initialization
    void Start()
    {
        if (thisGameobject.name == "locIcon")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[0];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[0];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon1")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[1];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[1];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon2")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[2];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[2];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon3")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[3];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[3];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon4")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[4];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[4];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon5")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[5];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[5];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon6")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[6];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[6];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon7")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[7];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[7];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon8")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[8];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[8];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon9")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[9];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[9];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon10")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[10];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[10];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon11")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[11];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[11];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon12")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[12];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[12];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon13")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[13];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[13];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon14")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[14];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[14];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon15")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[15];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[15];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon16")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[16];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[16];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon17")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[17];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[17];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon18")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[18];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[18];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon19")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[19];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[19];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon20")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[20];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[20];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon21")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[21];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[21];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon22")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[22];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[22];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon23")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[23];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[23];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon24")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[24];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[24];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon25")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[25];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[25];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon26")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[26];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[26];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon27")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[27];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[27];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon28")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[28];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[28];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon29")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[29];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[29];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon30")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[30];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[30];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon31")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[31];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[31];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon32")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[32];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[32];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon33")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[33];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[33];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon34")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[34];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[34];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon35")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[35];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[35];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon36")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[36];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[36];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon37")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[37];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[37];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
        else if (thisGameobject.name == "locIcon38")
        {
            distance = GameObject.Find("Camera").GetComponent<GPSScript>().jarakIkon;
            double latTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lat[38];
            double lonTarget = GameObject.Find("Camera").GetComponent<GPSScript>().lon[38];
            double latPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().latFix;
            double lonPlayer = GameObject.Find("Camera").GetComponent<GPSScript>().lonFix;
            bearing = getBearing(latTarget, lonTarget, latPlayer, lonPlayer);
            thisGameobject.transform.Rotate(0, bearing, 0);
        }
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
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 1;
        }
        else if (thisGameobject.name == "locIcon1")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 1;
        }
        else if (thisGameobject.name == "locIcon2")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 1;
        }
        else if (thisGameobject.name == "locIcon3")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 2;
        }
        else if (thisGameobject.name == "locIcon4")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 3;
        }
        else if (thisGameobject.name == "locIcon5")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 3;
        }
        else if (thisGameobject.name == "locIcon6")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 4;
        }
        else if (thisGameobject.name == "locIcon7")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 5;
        }
        else if (thisGameobject.name == "locIcon8")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 6;
        }
        else if (thisGameobject.name == "locIcon9")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 7;
        }
        else if (thisGameobject.name == "locIcon10")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 7;

        }
        else if (thisGameobject.name == "locIcon11")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 8;
        }
        else if (thisGameobject.name == "locIcon12")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 9;
        }
        else if (thisGameobject.name == "locIcon13")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 9;
        }
        else if (thisGameobject.name == "locIcon14")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);
            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 9;
        }
        else if (thisGameobject.name == "locIcon15")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[0].SetActive(true);

            pic3D[0].GetComponent<facultyInfoScript>().idFaculty = 10;
        }
        else if (thisGameobject.name == "locIcon16")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);
            
            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon17")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon18")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon19")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon20")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon21")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon22")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon23")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon24")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon25")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon26")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon27")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon28")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon29")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon30")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon31")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon32")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon33")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon34")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon35")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon36")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon37")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }
        else if (thisGameobject.name == "locIcon38")
        {
            pic3D[0].SetActive(false);
            pic3D[1].SetActive(false);
            pic3D[2].SetActive(false);

            pic3D[1].SetActive(true);
        }

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
