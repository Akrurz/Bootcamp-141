using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] StarterAssets.ThirdPersonController tps;
    [SerializeField] StarterAssets.StarterAssetsInputs starter;
    [SerializeField] Game_Timer stoptimer;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _playerFollow;
    [SerializeField] Transform teleportLine;

    Vector3 Vector3;
    void Start()
    {
      
    }

    public void Quit()
    {
        Application.Quit();
    }

    
    void Update()
    {
        
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LifeTime()
    {
        anim.SetBool("Death", false);
        tps._playerInput.enabled = true;
    }
    public void Hunger()
    {
        anim.SetBool("Death", true);
        tps._playerInput.enabled = false;
        Invoke("Retry",2f);

    }

    public void Quiz()
    {
        starter.cursorLocked = false;
        starter.cursorLocked = false;
        stoptimer.currentTime = 2f;
        stoptimer.timeCont = true;
        tps._playerInput.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuizFree()
    {
        starter.cursorLocked = true;
        starter.cursorLocked = true;
        stoptimer.currentTime = 1f;
        stoptimer.timeCont = false;
        tps._playerInput.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Teleport()
    {
        
        
        
        QuizFree();

    }
    public void Isýnlan()
    {
        _player.transform.position = teleportLine.transform.position;
    }

}
