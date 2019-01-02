using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsumoPanelManager : MonoBehaviour {

    public GameObject scoreManagerObj;

    int _riichCount;

	// Use this for initialization
	void Start () {
        _riichCount = scoreManagerObj.GetComponent<ScoreManager>().riichCount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
