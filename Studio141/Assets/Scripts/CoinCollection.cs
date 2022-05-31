using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicListNS;

using CDTimerNS; //Countdown timer


    public class CoinCollection : MonoBehaviour
    {
       
        // Start is called before the first frame update
        GameObject music;
        private CoinInst randomizer;
        [SerializeField] GameObject _gameObject;
        // private int totalSpawnPoints;
        int y;
   

        private int count = 0;

        MusicList musicList;
      
        private void Start()
        {
            music = GameObject.Find("AudioManager");
            musicList = music.GetComponent(typeof(MusicList)) as MusicList;
        
           

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("food"))
            {
                count++;
             CDTimer.currentTime= CDTimer.currentTime+30;
                other.gameObject.SetActive(false);
                AudioSource.PlayClipAtPoint(musicList.music[0], gameObject.transform.position);
                StartCoroutine(Spawn(other.gameObject));
            }
        }
        IEnumerator Spawn(GameObject _gameObject)
        {
            yield return new WaitForSeconds(3);
            gameObject.SetActive(true);

        }

    }

