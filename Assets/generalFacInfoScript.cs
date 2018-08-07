using UnityEngine;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;
using System.IO;

public class generalFacInfoScript : MonoBehaviour
{

    public GameObject[] respawns;
    public Text getIdFacility;
    public Text locationName;
    public TextMesh time;
    public TextMesh cp;
    public TextMesh price;
    public int idFacilty;
    public string locDesc;
    private IDbConnection dbc;

    //    // Use this for initialization
    void Start()
    {
        
    }

    private void OnEnable()
    {
        idFacilty = Convert.ToInt32(getIdFacility.text);

        //        // search idInfo from GPSScript
        string _constr = Application.persistentDataPath + "/" + "skripsiDB.db";
        //        // on Android
        if (!File.Exists(_constr))
        {
            WWW getDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + "skripsiDB.db");

            while (!getDB.isDone)
            {
            }

            File.WriteAllBytes(_constr, getDB.bytes);
        }

        string conn = "URI=file:" + _constr;
        //        //WWW dbPath = new WWW(path);
        dbc = new SqliteConnection(conn);
        dbc.Open();

        IDbCommand _dbcm = dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'facility' WHERE idFacility = " + idFacilty;
        IDataReader _dbr = _dbcm.ExecuteReader();

        while (_dbr.Read())
        {
            locationName.text = _dbr.GetString(1);
            time.text = "Buka : " + _dbr.GetString(2) + "\n" + "Tutup : " + _dbr.GetString(3);
            locDesc = _dbr.GetString(4);
            cp.text = _dbr.GetString(5);
            price.text = "Rp." + _dbr.GetInt32(6) + " - " + "Rp." +_dbr.GetInt32(7);
        }
    }

    //	// Update is called once per frame
    void Update()
    {
        
    }
}
