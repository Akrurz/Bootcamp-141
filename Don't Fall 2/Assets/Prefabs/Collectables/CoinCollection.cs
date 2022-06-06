using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CoinCollection : MonoBehaviour
{

    [SerializeField] GameObject quiz;
    [SerializeField] GameManager manager;
    GameObject music;
    private CoinInst randomizer;
    [SerializeField] Game_Timer gameTime;
    [SerializeField] GameObject _gameObject;
    // private int totalSpawnPoints;
    int y;


    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            Debug.Log("temas");
            gameTime.currentTime = gameTime.currentTime + .1f;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Portal"))
        {
            quiz.SetActive(true);
            manager.Quiz();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            manager.Isýnlan();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("water"))
        {
            manager.Retry();
        }
    }
    IEnumerator Spawn(GameObject _gameObject)
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(true);

    }



}

