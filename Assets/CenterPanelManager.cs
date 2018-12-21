using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterPanelManager : MonoBehaviour {

    Text riichText;
    Text roundBarText;

	// Use this for initialization
	void Start () {
        var riichObj = transform.Find("RiichiBar").Find("RiichBarNum");
        riichText = riichObj.gameObject.GetComponent<Text>();
        var roundBarObj = transform.Find("RoundBar").Find("RoundBarNum");
        roundBarText = roundBarObj.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetRiichBar(int num) {
        riichText.text = "x " + num.ToString();
    }

    public void SetRoundBar(int num) {
        roundBarText.text = "x " + num.ToString();
    }
}
