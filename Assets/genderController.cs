using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genderController : MonoBehaviour
{
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void chooseCountry()
    {


        next.SetActive(true);
        this.gameObject.SetActive(false);
    }
    
}
