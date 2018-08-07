//using UnityEngine;
//using System.Collections;
//using System;
//using Mono.Data.Sqlite;
//using System.Data;
//using UnityEngine.UI;
//using System.IO;

//public class sportsAndArtInfoScript : MonoBehaviour {

//    public GameObject[] respawns;
//    public Text description;
//    private string id;
//    private IDbConnection dbc;

//    // Use this for initialization
//    void Start () {
//        // search idInfo from GPSScript
//        string _constr = Application.persistentDataPath + "/" + "skripsiDB.db";
//        // on Android
//        if (!File.Exists(_constr))
//        {
//            WWW getDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + "skripsiDB.db");

//            while (!getDB.isDone)
//            {
//            }

//            File.WriteAllBytes(_constr, getDB.bytes);
//        }

//        string conn = "URI=file:" + _constr;
//        //WWW dbPath = new WWW(path);
//        dbc = new SqliteConnection(conn);
//        dbc.Open();

//        //_dbr.Close();
//    }

//    // Update is called once per frame
//    void Update () {
//        // get id terbaru, loop terus
//        id = findIdInfo("camera");
//        IDbCommand _dbcm = dbc.CreateCommand();
//        _dbcm.CommandText = "select * " + "FROM 'sportsAndArts' WHERE idInfo = " + id;
//        IDataReader _dbr = _dbcm.ExecuteReader();

//        while (_dbr.Read())
//        {
//            respawns[0].GetComponent<TextMesh>().text = "Open : " + _dbr.GetString(2) + "\n" + "Close : " + _dbr.GetString(3);
//            respawns[1].GetComponent<TextMesh>().text = _dbr.GetString(5);
//            respawns[2].GetComponent<TextMesh>().text = "Weekday : Rp." + _dbr.GetInt32(6).ToString() + "\n" + "Weekend : Rp." + _dbr.GetInt32(7).ToString();
//            description.text = _dbr.GetString(4);
//        }
//    }

//    string findIdInfo(string gameObjectName)
//    {
//        GameObject getGameObject = GameObject.Find("Camera");
//        GPSScript gpsScript = getGameObject.GetComponent<GPSScript>();
//        respawns = GameObject.FindGameObjectsWithTag("sportsArtInfo");

//        if (gpsScript.idInfo == 0)
//        {
//            return "1";
//        }
//        else
//        {
//            return gpsScript.idInfo.ToString();
//        }
//    }
//}
