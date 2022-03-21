using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackgroundChange : MonoBehaviour
{
    public int num=0;
  //  public Material[] skyone;
    public Image old;
 //   public Sprite[] new1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1)
        {
           //RenderSettings.skybox=skyone[0];
         //  old.sprite=new1[0];
        }
        if(num==2)
        {
            Debug.Log("Hello");
        }
        if(num==3)
        {
            Debug.Log("Hello");
        }
    }
}
