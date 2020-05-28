﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasOperator : MonoBehaviour {
    Text text;

    void Start() {
        text = GetComponent<Text>();
        text.text = "Lives: " + GlobalVars.initLives;
    }

    public void SetText(string textIn) {
        text.text = textIn;
    }
}
