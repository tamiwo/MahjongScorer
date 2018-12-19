using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public GameObject[] players;
    public int startScore;

    PlayerManager[] _playerMng;

    void Start()
    {
        _playerMng = new PlayerManager[players.Length];
        var i = 0;
        foreach (GameObject p in players) {
            _playerMng[i] = p.GetComponent<PlayerManager>();
            _playerMng[i].SetScore(startScore);
            i += 1;
        }
    }
}
