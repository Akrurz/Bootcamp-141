using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class next_level : MonoBehaviour
{
     [SerializeField] private GameObject canvas;
/*[SerializeField] private GameObject _gameTime;
[SerializeField] private GameObject _goToArch;*/
  private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("nextlevel"))
            {
               // _gameTime.SetActive(true);
              Debug.Log("Entered");
              
               //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
                 Invoke("LaodNextLevel", 2);//this will happen after 2 seconds
            }
           else if (other.gameObject.CompareTag("tonextlevel"))
            {
               // _goToArch.SetActive(true);
              
              
               //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
                // Invoke("LaodNextLevel", 2);//this will happen after 2 seconds
            }
        }

       
 void LaodNextLevel()
{
    Cursor.lockState= CursorLockMode.None;
    Cursor.visible= true;
    canvas.SetActive(true);
    //Time.timeScale = 0f;
    //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
 
	
}

}
