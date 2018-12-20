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

    public void SetName(int id, string str) {
        var old = _playerMng[id].GetName();
        Debug.Log(id + ":" + str);
        _playerMng[id].SetName(str);
        for (int i = 0; i < 4; i++) {
            if (i == id) continue;
            if ( _playerMng[i].GetName() == str ) {
                _playerMng[i].SetName(old);
                break;
            }
        }
    }
}