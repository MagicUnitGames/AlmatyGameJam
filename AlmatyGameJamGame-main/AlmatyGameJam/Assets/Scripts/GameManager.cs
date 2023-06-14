using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject mainScene;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void OnMainActivate()
    {
        DontDestroyOnLoad(mainScene);
        mainScene.SetActive(true);
    }

    public void OnSceneLoaded()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(mainScene);
        mainScene.SetActive(false);
    }
}
