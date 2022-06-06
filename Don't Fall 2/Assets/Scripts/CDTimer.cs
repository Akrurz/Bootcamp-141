using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;



namespace CDTimerNS{
public class CDTimer : MonoBehaviour
    {

        [SerializeField] private TMP_Text _text;
        [SerializeField] private GameObject _gameOver;
        Animator anim;
         
       public static float currentTime = 0f;
        float startTime = 30f;
        float ratio = 0.016f;
        int hour = 0;
        int minutes = 0;


        // Start is called before the first frame update
        void Start()
        {
            currentTime = startTime;
             anim = GetComponent<Animator>();
        }
        

        // Update is called once per frame
        void Update()
        {
            currentTime -= ratio * Time.deltaTime;
            if (currentTime >= 60)
            {
                hour = (int)currentTime / 60;
                minutes = (int)currentTime % 60;
                if (hour < 10)
                {
                    if (minutes < 10)
                    {
                        _text.text = "0" + hour + ":" + "0" + minutes;
                    }
                    else
                    {
                        _text.text = "0" + hour + ":" + minutes;
                    }


                }
                else
                {
                    if (minutes < 10)
                    {
                        _text.text = hour + ":" + "0" + minutes;
                    }
                    else
                    {
                        _text.text = hour + ":" + minutes;
                    }

                }


            }
            else
            {
                if (currentTime >= 10)
                {
                    _text.text = "00" + ":" + currentTime.ToString("0");

                }
                else
                {

                    _text.text = "00" + ":" + "0" + currentTime.ToString("0");

                }
                if (currentTime <= 0)
                {

                    finishGame();

                }


            }

            print(currentTime);
            

        }

        void finishGame()
        {
          anim.SetBool("Death", true);
          anim.SetBool("GettUp", false);
            _gameOver.SetActive(true);
            StartCoroutine(ExecuteAfterTime(3)); //To stop the time
           

        }

         IEnumerator ExecuteAfterTime(float time)
 {
     yield return new WaitForSeconds(time);
     Time.timeScale = 0f;
     
 }

       
    }
}

