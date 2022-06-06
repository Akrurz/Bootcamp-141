using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
public class UiManager : MonoBehaviour
{
    [SerializeField]
    CinemachineDollyCart cinemachineDolly;
    bool _enableMenu;
    [SerializeField] GameObject _settings, _story, _team, _startUi;
    [SerializeField]
    StorySublities storyS;
    void Start()
    {
        //cinemachineDolly = GetComponent<CinemachineDollyCart>();
        //storyS = GetComponent<StorySublities>();
    }

    
    void LateUpdate()
    {

        if (cinemachineDolly.m_Position > 95f && !_enableMenu)
        {
            _startUi.SetActive(true);
        }


    }

    public void Story()
    {
        _startUi.SetActive(false);
        _enableMenu = true;
        _settings.SetActive(false);
        _team.SetActive(false);
        
        _story.SetActive(true);
        storyS.ChecBox();

    }

    public void Back()
    {
        _team.SetActive(false);
        _story.SetActive(false);
        _startUi.SetActive(true);
        _settings.SetActive(false);
        _enableMenu = false;
    }
    public void Settings()
    {
        _startUi.SetActive(false);
        _enableMenu = true;
        _settings.SetActive(true);
        _team.SetActive(false);
        _story.SetActive(false);
    }
    public void Play()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Team()
    {
        _startUi.SetActive(false);
        _enableMenu = true;
        _settings.SetActive(false);
        _team.SetActive(true);
        _story.SetActive(false);
    }
}
