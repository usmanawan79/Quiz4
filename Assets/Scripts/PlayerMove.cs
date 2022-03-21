using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    float horizontal;
    float range=8.50f;
    public GameObject bullet;
   public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontal*Time.deltaTime*10.0f);
        if(transform.position.x>range)
        {
            transform.position=new Vector3(range,transform.position.y,transform.position.z);
        }
        if(transform.position.x<-range)
        {
            transform.position=new Vector3(-range,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet,transform.position,Quaternion.identity);
        }
    }
   
}
