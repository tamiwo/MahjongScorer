using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    private Text _score;
    private Text _name;
    private Text _wind;

    // Use this for initialization
    void Awake () {
        _score = transform.Find("ScorePanel").Find("Score").gameObject.GetComponent<Text>();
        _name = transform.Find("NameButton").Find("Name").gameObject.GetComponent<Text>();
        _wind = transform.Find("WindButton").Find("Wind").gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void SetScore( int score ) {
        _score.text = score.ToString();
    }

    public void SetName( string name ) {
        _name.text = name;
    }

    public string GetName(){
        return _name.text;
    }

    public void SetWind(string wind)
    {
        _wind.text = wind;
        Debug.Log(wind);
    }

    public string GetWind()
    {
        return _wind.text;
    }

}
