using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{
    public BackgroundChange BackC;
    // Start is called before the first frame update
    void Start()
    {
        //BackgroundChange BackC=new BackgroundChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sceneloader()
    {
        SceneManager.LoadScene(1);
    }
    public void Ack1()
    {
        BackC.num=1;
    }
    public void Ack2()
    {
        BackC.num=2;
    }
    public void Ack3()
    {
        BackC.num=3;
    }
}
