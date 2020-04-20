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

    [FMODUnity.EventRef]
    public string MainMusic;
    private EventInstance mainMusic;

    void Start()
    {
        menuClick = FMODUnity.RuntimeManager.CreateInstance(MenuClick);
        mainMusic = FMODUnity.RuntimeManager.CreateInstance(MainMusic);
        mainMusic.start();
    }

    public void LoadScene(int level)
    {
        mainMusic.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        menuClick.start();
        SceneManager.LoadScene(level, LoadSceneMode.Single);

    }
}
