using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameManager : MonoBehaviour {

    public string[] NameList;
    public GameObject[] players;

    PlayerManager[] _playerMng;

    // Use this for initialization
    void Start () {
        _playerMng = new PlayerManager[players.Length];
        var i = 0;
        foreach (GameObject p in players) {
            _playerMng[i] = p.GetComponent<PlayerManager>();
            _playerMng[i].SetName(NameList[i]);
            i += 1;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
