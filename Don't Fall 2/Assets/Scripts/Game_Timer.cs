using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Game_Timer : MonoBehaviour
{
    [SerializeField] Slider hpSlider;
    [SerializeField] GameManager manager;
    public bool timeCont = false;
    public float currentTime = 2f;
    float startTime = 1f;
    float ratio = 0.016f;


    void Start()
    {
        currentTime = startTime;
    }


    // Update is called once per frame
    void Update()
    {
        if (!timeCont)
        {
            currentTime -= ratio * Time.deltaTime;
            hpSlider.value = currentTime * 2;
            if (currentTime < 0.1f)
            {
                manager.Hunger();
            }
        }
 
        //Debug.Log(currentTime);
    }


}
