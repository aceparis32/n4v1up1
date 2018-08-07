using UnityEngine;
using System.Collections;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;
using System.IO;

public class databaseScript : MonoBehaviour {

    // store data from queries
    public int iteration = 0;
    public int[] idInfoData;
    public int[] idCategoryData;
    public double[] lonData;
    public double[] latData;
    public string[] buildingGroup;
    public Sprite[] buildingImage;
    // Use this for initialization
    void Start () {
        Debug.Log(GameObject.Find("Camera").name);
        iteration = 0;
        // test on PC
        // db in C:\Users\Redshift\AppData\LocalLow\aceparis32\upiNav
        // on Android
        // db in D:\Kuliah\SKRIPSI\upiNav\Assets\StreamingAssets
        string _constr = Application.persistentDataPath + "/" + "skripsiDB.db";
        if (!File.Exists(_constr))
        {
            WWW getDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + "skripsiDB.db");

            while (!getDB.isDone)
            {
            }

            File.WriteAllBytes(_constr, getDB.bytes);
        }

        string conn = "URI=file:" + _constr;
        //WWW dbPath = new WWW(path);
        IDbConnection _dbc;
        _dbc = new SqliteConnection(conn);
        _dbc.Open();
        IDbCommand _dbcm = _dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'facultyInfo'";
        IDataReader _dbr = _dbcm.ExecuteReader();

        while (_dbr.Read())
        {
            idInfoData[iteration] = iteration;
            idCategoryData[iteration] = _dbr.GetInt32(1);
            latData[iteration] = _dbr.GetDouble(2);
            lonData[iteration] = _dbr.GetDouble(3);
            buildingGroup[iteration] = _dbr.GetString(4);
            iteration++;
        }

        //_dbr.Close();
        //_dbcm.Dispose(); 
        _dbcm = _dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'facilityInfo'";
        _dbr = _dbcm.ExecuteReader();

        while (_dbr.Read())
        {
            idInfoData[iteration] = iteration;
            idCategoryData[iteration] = _dbr.GetInt32(1);
            latData[iteration] = _dbr.GetDouble(2);
            lonData[iteration] = _dbr.GetDouble(3);
            buildingGroup[iteration] = _dbr.GetString(4);
            iteration++;
        }

        _dbc.Close();
        _dbcm.Dispose();
        _dbc.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
