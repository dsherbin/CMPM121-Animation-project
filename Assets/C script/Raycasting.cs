using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (Physics.Raycast(new Ray(transform.position, transform.forward), out hit, 3f, LayerMask.GetMask("Default"))){
            if (hit.transform.gameObject.tag == "Door")
            {
                Debug.Log("Hitting a Door");
            }
        }
    }
}
