﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour {

    public Node node;

    public Image icon;
    void Awake()
    {
        icon = GetComponent<Image>();

    }
}