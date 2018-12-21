using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public GameObject[] players;
    public int startScore;

    PlayerManager[] _playerMng;
    int[] _scores;
    bool[] _isRiich;

    void Start()
    {
        _playerMng = new PlayerManager[players.Length];
        _scores = new int[players.Length];
        _isRiich = new bool[players.Length];
        var i = 0;
        foreach (GameObject p in players) {
            _playerMng[i] = p.GetComponent<PlayerManager>();
            SetScore(i,startScore);
            i += 1;
        }
    }

    void SetScore ( int id, int score ) {
        _scores[id] = score;
        _playerMng[id].SetScore(score);
    }

    public void Riich(int id) {
        if (_isRiich[id] == false) {
            SetScore(id, _scores[id] - 1000);
        }
        else {
            SetScore(id, _scores[id] + 1000);
        }
        _isRiich[id] = !_isRiich[id];
    }
}
