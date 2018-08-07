using UnityEngine;
using System.Collections;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;
using System.IO;

public class facultyInfoScript : MonoBehaviour {

    public GameObject thisGameObject;
    public GameObject[] respawns;
    public Text locationName;
    public Text description;
    public Text getBearing;
    public Text getIdFaculty;
    public int idFaculty;
    public float bearing;
    public string locDesc;
    public GameObject dropdownJurusan;
    public Text id;
    
    private IDbConnection dbc;

    void Start()
    {

    }

    void OnEnable()
    {
        // reset gameobject
        idFaculty = Convert.ToInt32(getIdFaculty.text);
        id.text = getIdFaculty.text;
        dropdownJurusan.SetActive(false);
        
        // search idInfo from onclickIconScripts
        string _constr = Application.persistentDataPath + "/" + "skripsiDB.db";
        // on Android
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
        dbc = new SqliteConnection(conn);
        dbc.Open();

        IDbCommand _dbcm = dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'faculty' WHERE idFaculty = " + getIdFaculty.text;
        IDataReader _dbr = _dbcm.ExecuteReader();

        while (_dbr.Read())
        {
            idFaculty = _dbr.GetInt32(0);
            locationName.text = _dbr.GetString(1);
            locDesc = _dbr.GetString(2);
        }
        dropdownJurusan.SetActive(true);
    }


    // Use this for initialization
    void Update () {

        
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
