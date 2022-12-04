using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyBGMusic : MonoBehaviour
{
    //public static DontDestroyBGMusic instance = null;
    //GameObject BGMObj = GameObject.FindGameObjectWithTag("BGM");

    //private void Awake()
    //{
    //    if (instance == null) { instance = this; }
    //    else if (instance != null)
    //    {
    //        Destroy(BGMObj);
    //    }
    //    DontDestroyOnLoad(BGMObj);
    //}
    //public AudioSource[] bgm_files;
    //void Start()
    //{
    //    SameBGMSettings();
    //}

    //private void SameBGMSettings()
    //{
    //    float bgm_slider_value = PlayerPrefs.GetFloat("bgm_value", 0.5f);
    //    for (int i = 0; i < bgm_files.Length; i++)
    //    {
    //        bgm_files[i].volume = bgm_slider_value;
    //    }
    //}

    private void Awake()
    {
        GameObject[] BGMObjGamePlay = GameObject.FindGameObjectsWithTag("BGMGamePlay");
        GameObject[] BGMObj = GameObject.FindGameObjectsWithTag("BGM");

        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "MainMenu")
        {
            BGMObjGamePlay[0].SetActive(false);
            Destroy(this.gameObject);
            Destroy(BGMObjGamePlay[0]);
        }


        if (BGMObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        if (BGMObjGamePlay.Length >= 2)
        {
            Destroy(this.gameObject);
        }
        else if (currentSceneName != "MainMenu" && this.gameObject.CompareTag("BGMGamePlay"))
        {
            BGMObjGamePlay[0].SetActive(true);
            DontDestroyOnLoad(this.gameObject);
        }

        else if (currentSceneName == "MainMap" && this.gameObject.CompareTag("BGMGamePlay"))
        {
            BGMObjGamePlay[0].SetActive(false) ;
            Destroy(this.gameObject);
            Destroy(BGMObjGamePlay[0]);
        }

        // if (SFXObj.Length > 1)
        // {
        //     Destroy(this.gameObject);
        // }

    }

    private void Update()
    {
        GameObject[] BGMObjGamePlay = GameObject.FindGameObjectsWithTag("BGMGamePlay");
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "MainMenu" && this.gameObject.CompareTag("BGMGamePlay"))
        {
            BGMObjGamePlay[0].SetActive(false);
            Destroy(this.gameObject);
            Destroy(BGMObjGamePlay[0]);
        }
    }
}
