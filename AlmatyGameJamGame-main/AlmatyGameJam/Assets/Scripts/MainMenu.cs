using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject startb;
    public GameObject quitb;


    public void Startm()
    {
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;
    }

    public void Quitm()
    {
        Application.Quit();
        print("quitted");
    }
}
