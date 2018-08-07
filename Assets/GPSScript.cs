using UnityEngine;
using System.Collections;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;
using System.IO;

public class GPSScript : MonoBehaviour {
    
    public GameObject[] iconLocation;
    private GameObject getDataFromScript;
    private databaseScript dbScript;
    private double distanceTemp = 0;
    private int totalFound;
    public double[] jarak;
    public double jarakIkon;

    public Text location;
    //public Text lat;
    public double[] lon;
    public double[] lat;
    public Text distance;
    public Text latlon;
    public Image compassImage;
    public int idCategory;
    public int idBuildingImage;
    public double latFix, lonFix;

    IEnumerator Start()
    {
        totalFound = 0;
        yield return new WaitForSeconds(3);
        getDataFromScript = GameObject.Find("Canvas");
        dbScript = getDataFromScript.GetComponent<databaseScript>();

        //while (true)
        //{
            // First, check if user has location service enabled
            if (!Input.location.isEnabledByUser)
                yield break;

            // Start service before querying location
            Input.location.Start();
            //Input.compass.enabled = true;

            // Wait until service initializes
            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
            }

            // Service didn't initialize in 20 seconds
            if (maxWait < 1)
            {
                print("Timed out");
                yield break;
            }

            // Connection has failed
            if (Input.location.status == LocationServiceStatus.Failed)
            {
                print("Unable to determine device location");
                yield break;
            }
            else
            {
                //compassImage.transform.localRotation = Quaternion.Euler(0, 0, Input.compass.trueHeading);
                //lon.text = Input.location.lastData.longitude.ToString();
                double convDouble = Convert.ToDouble(Input.location.lastData.longitude);
                var roundDouble = Math.Round(convDouble, 6);
                double convDouble2 = Convert.ToDouble(Input.location.lastData.latitude);
                var roundDouble2 = Math.Round(convDouble2, 6);
    
                latFix = roundDouble2;
                lonFix = roundDouble;
                
                //latlon.text = latFix.ToString("G") + "," + lonFix.ToString("G");
                for (int i = 0; i < dbScript.iteration; i++)
                {
                    jarak[i] = getDistance(latFix, lonFix, dbScript.latData[i], dbScript.lonData[i]);
                    if (jarak[i] <= 50)
                    {
                        // new code
                        // jika ada lokasi yang kurang dari 30 meter, munculkan ikon lokasi di AR
                        totalFound++;
                        jarakIkon = jarak[i];
                        lat[i] = dbScript.latData[i];
                        lon[i] = dbScript.lonData[i];
                        iconLocation[i].SetActive(true);
                    
                        //// jika ditemukan lebih dari 1 data, maka pilih yang jaraknya paling dekat
                        //if (distanceTemp == 0)
                        //{
                        //    distanceTemp = jarak[i];
                        //}

                        //if (jarak[i] <= distanceTemp)
                        //{
                        //    distanceTemp = Convert.ToInt32(jarak[i]);
                        //    idBuildingImage = dbScript.idInfoData[i];
                        //    idCategory = dbScript.idCategoryData[i];
                        //    lat = dbScript.latData[i];
                        //    lon = dbScript.lonData[i];
                        //    distance.text = "Jarak : " + distanceTemp.ToString() + " meter";

                        //    if (dbScript.idCategoryData[i] > 0 && dbScript.idCategoryData[i] <= 10)
                        //    {
                        //        pic3D[0].SetActive(true);
                        //        pic3D[1].SetActive(false);
                        //        pic3D[2].SetActive(false);
                        //    }
                        //    else if (dbScript.idCategoryData[i] > 10)
                        //    {
                        //        pic3D[0].SetActive(false);
                        //        pic3D[1].SetActive(true);
                        //        pic3D[2].SetActive(false);
                        //    }
                        //}
                    }
                }

                location.text = "Ditemukan " + totalFound.ToString() + " Lokasi";
                //lon.text = Input.location.lastData.longitude.ToString("R") + "===" + roundDouble.ToString() + "-" + Input.location.lastData.longitude; 
            }
        //}
        // Stop service if there is no need to query location updates continuously
        //Input.location.Stop();
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
