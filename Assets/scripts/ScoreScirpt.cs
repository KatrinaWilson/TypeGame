﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScirpt : MonoBehaviour {

    public static int scoreValue = 0;
    Text ScoreText;
	// Use this for initialization
	void Start () {
        ScoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text ="Words Typed: " + scoreValue;
	}
}
