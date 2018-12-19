using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameListPanelManager : MonoBehaviour {

    public GameObject nameManager;

    private Text[] _names;

    private void Awake() {
        _names = new Text[4];
        for (int i = 0; i < 4; i++) {
            var obj = transform.Find("NameListButton" + (i + 1)).Find("Text").gameObject;
            _names[i] = obj.GetComponent<Text>();
        }
    }

    // Use this for initialization
    void Start () {
        var nameList = nameManager.GetComponent<NameManager>().NameList;
        for (int i = 0; i < 4; i++) {
            _names[i].text = nameList[i];
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
