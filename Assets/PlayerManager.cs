using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    private Text _score;

	// Use this for initialization
	void Start () {
        _score = transform.Find("ScorePanel").Find("Score").gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetScore( int score ) {
        _score.text = score.ToString();
    }
}
