using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour {
    
    public GameObject[] players;

    string[] _windList;
    PlayerManager[] _playerMng;

    // Use this for initialization
    void Start () {
        _playerMng = new PlayerManager[players.Length];
        _windList = new string[] { "東", "南", "西", "北" };
        var i = 0;
        foreach (GameObject p in players) {
            _playerMng[i] = p.GetComponent<PlayerManager>();
            _playerMng[i].SetWind(_windList[i]);
            i += 1;
        }
    }

    // Update is called once per frame
    void Update () {

    }

    public void NextWind() {
        int windNo = 0;
        for (int i = 0; i < 4; i++) {
            if (_playerMng[0].GetWind() == _windList[i]) {
                windNo = i;
                break;
            }
        }
        for (int i = 0; i < 4; i++) {
            _playerMng[i].SetWind(_windList[(windNo + i + 3) % 4]);
        }
    }
}
