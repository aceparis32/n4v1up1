using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickContactScript : MonoBehaviour
{

    private string contactNumber;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        contactNumber = GameObject.Find("infoFasilitasPublik").GetComponent<generalFacInfoScript>().cp.text;
        Application.OpenURL("tel://" + contactNumber);
    }
}
