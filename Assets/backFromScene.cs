using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class backFromScene : MonoBehaviour
{
    public bool vr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (vr)
            {
                XRSettings.enabled = false;
                SceneManager.LoadScene("main Scene");

            }
            else { 
            SceneManager.LoadScene("main Scene");
            }
        }
    }
}
