using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_ScoreText : MonoBehaviour {

    Text score_text;

	// Use this for initialization
	void Start () {

        score_text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        score_text.text = "" + Parameter.score;
	}
}
