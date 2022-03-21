using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    float topbound=5.5f;
   PlayerMove playM;
    // Start is called before the first frame update
 
    void Start()
    {
     PlayerMove playM=new PlayerMove();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up* Time.deltaTime * 8.0f);
        if(transform.position.y>topbound)
        {
            Destroy(gameObject);
        }
    }
     
    private void OnCollisionEnter2D(Collision2D other) {
    
        Destroy(other.gameObject);
        Destroy(gameObject);
       // Debug.Log("hit");
        
    }
   
}
