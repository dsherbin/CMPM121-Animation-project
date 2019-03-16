using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger1 : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("enter cube");
        Cam1.enabled = false;
        Cam2.enabled = true;
        
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit cube");
        Cam1.enabled = true;
        Cam2.enabled = false;
    }



}
