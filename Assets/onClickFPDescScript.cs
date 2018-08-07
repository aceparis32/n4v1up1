using UnityEngine;
using UnityEngine.UI;

public class onClickFPDescScript : MonoBehaviour {

    public Text text;
    private string descText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        descText = GameObject.Find("infoFasilitasPublik").GetComponent<generalFacInfoScript>().locDesc;
        text.text = "Deskripsi : \n" + descText;
    }
}
