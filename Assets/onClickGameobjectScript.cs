using UnityEngine;
using UnityEngine.UI;

public class onClickGameobjectScript : MonoBehaviour {

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
        descText = GameObject.Find("infoFakultas").GetComponent<facultyInfoScript>().locDesc;
        text.text = "Deskripsi : \n" + descText;
    }
}
