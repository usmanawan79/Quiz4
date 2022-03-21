using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int enemyCount;
    public GameObject[] enemyWave;
    Vector3 V=new Vector3(0,0,0);
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         enemyCount = GameObject.FindGameObjectsWithTag ("Enemy").Length;
        // Debug.Log("Enemy count"+enemyCount); 
         if(enemyCount==0)
         {
             Instantiate(enemyWave[i],V,Quaternion.identity);
             i++;
             if(i>2)
             {
                 i=0;
             }
         }
    }
}
