using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMOD.Studio;
using FMODUnity;

public class SceneLoader : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string MenuClick;
    private EventInstance menuClick;


    void Start()
    {
        menuClick = FMODUnity.RuntimeManager.CreateInstance(MenuClick);

    }

    public void LoadScene(int level)
    {
        menuClick.start();
        SceneManager.LoadScene(level, LoadSceneMode.Single);

    }
}
