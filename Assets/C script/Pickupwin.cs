using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickupwin : MonoBehaviour
{
    public GameObject keygone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            keygone.SetActive(false);
            SceneManager.LoadScene(0);


        }


    }
}

