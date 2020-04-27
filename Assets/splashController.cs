using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashController : MonoBehaviour
{
    public GameObject gender;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("showGender", 3f);
    }

    // Update is called once per frame
    void showGender()
    {
        this.gameObject.SetActive(false);
        gender.SetActive(true);
    }
}
