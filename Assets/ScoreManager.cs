using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public GameObject[] players;
    public int startScore;
    public GameObject centerPanel;

    PlayerManager[] _playerMng;
    CenterPanelManager _centerPanelMng;
    int[] _scores;
    bool[] _isRiich;
    public int riichCount=0;

    void Start()
    {
        _playerMng = new PlayerManager[players.Length];
        _centerPanelMng = centerPanel.GetComponent<CenterPanelManager>();
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
            _centerPanelMng.SetRiichBar(++riichCount);
        }
        else {
            SetScore(id, _scores[id] + 1000);
            _centerPanelMng.SetRiichBar(--riichCount);
        }
        _isRiich[id] = !_isRiich[id];
    }
}
