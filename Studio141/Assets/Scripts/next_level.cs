using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class next_level : MonoBehaviour
{
[SerializeField] private GameObject _gameTime;
  private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("nextlevel"))
            {
                _gameTime.SetActive(true);
              
              
               //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
                 Invoke("LaodNextLevel", 2);//this will happen after 2 seconds
            }
        }

       
 void LaodNextLevel()
{
    SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	
}

}
