using UnityEngine;
using System.Collections.Generic;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;
using System.IO;

public class departmentListScript : MonoBehaviour {

    private IDbConnection dbc;
    private int idFaculty;
    private int index;
    public Dropdown dropdown;
    public Text depText;
    public Text getIdFaculty;
    public TextMesh departmentInfo;

    private List<string> dropdownItem = new List<string>();

    // Use this for initialization
    void Start () {
        
    }

    private void OnEnable()
    {
        //// search idInfo from GPSScript
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

        dropdown.ClearOptions();
        idFaculty = Convert.ToInt32(getIdFaculty.text);
        IDbCommand _dbcm = dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'department' where idFaculty = " + idFaculty;
        IDataReader _dbr = _dbcm.ExecuteReader();

        dropdownItem.Clear();
        dropdown.ClearOptions();

        while (_dbr.Read())
        {
            dropdownItem.Add(_dbr.GetString(2));
        }

        _dbr.Close();
        _dbcm.Dispose();

        dropdown.AddOptions(dropdownItem);
        // listener when item on dropdown is clicked
        dropdown.onValueChanged.AddListener(delegate
        {
            selectedDepartment(dropdown);
        });
    }

    private void OnMouseDown()
    {

    }
    private void OnDisable()
    {
    }

    // Update is called once per frame
    void Update () {

    }

    void selectedDepartment(Dropdown choice)
    {
        index = choice.value;
        getDepartmentData(dropdown.options[index].text);
    }

    void getDepartmentData(string departmentName)
    {
        IDbCommand _dbcm = dbc.CreateCommand();
        _dbcm.CommandText = "select * " + "FROM 'department' where depName = " + "'" + departmentName + "'";
        IDataReader _dbr = _dbcm.ExecuteReader();

        while (_dbr.Read())
        {
            departmentInfo.text = "Jurusan / Departemen : " + _dbr.GetString(2) + "\n" +
                "Akreditasi : " + _dbr.GetString(3) + "\n" + "Gelar : " + _dbr.GetString(4) + "\n"
                + "Web : " + _dbr.GetString(5);
        }

        _dbr.Close();
        _dbcm.Dispose();
    }
}
