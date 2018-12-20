using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameListBuutonManager : MonoBehaviour {

    NameListPanelManager _mng;
    string _name;

	// Use this for initialization
	void Start () {
        var p = transform.parent.gameObject;
        _mng = p.GetComponent<NameListPanelManager>();
        var c = transform.Find("Text").gameObject;
        name = c.GetComponent<Text>().text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Push(){
        _mng.SetName(name);
        _mng.gameObject.SetActive(false);
    }
}
