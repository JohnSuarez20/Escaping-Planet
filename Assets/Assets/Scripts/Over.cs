﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalComportamiento : MonoBehaviour
{
    public GameObject GameOverText;
    public static GameObject GameOverStatic;

    // Start is called before the first frame update
    void Start()
    {
        Over.GameOverStatic = GameOverText;
        Over.GameOverStatic.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public static void show()
    {
        Over.GameOverStatic.gameObject.SetActive(true);
    }
}
