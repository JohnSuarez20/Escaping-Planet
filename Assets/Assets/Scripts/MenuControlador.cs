﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControlador : MonoBehaviour
{
    public void cambiarEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }
}
