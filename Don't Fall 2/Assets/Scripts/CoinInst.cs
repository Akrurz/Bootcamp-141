using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using System;

public class CoinInst : MonoBehaviour
{
    
    
    public List<Transform> spawnPoints= new List<Transform>();
    [SerializeField] GameObject coin;
    public List<GameObject> gameObjects= new List<GameObject>();
  

    private void Start()
    {
        var random = new Random();
        HashSet<int> randomValues= new HashSet<int>();
      


      int a =(int)Math.Ceiling(spawnPoints.Count/2.0f);
      

      
      
        while(randomValues.Count<a){
          
            randomValues.Add(random.Next(0,spawnPoints.Count-1));
            
        }
        int counter= 0;
        
        foreach(var x in randomValues){

            Instantiate(gameObjects[counter], spawnPoints[x]);
            counter++;
            if(counter>=gameObjects.Count){
                counter=0;
            }

        }


    }


}
