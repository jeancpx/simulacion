﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void EscMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Escena1() {
        SceneManager.LoadScene(1);
    }
    public void Escena2()
    {
        SceneManager.LoadScene(2);
    }
    public void Escena3()
    {
        SceneManager.LoadScene(3);
    }
    public void Escena4()
    {
        SceneManager.LoadScene(4);
    }
}
