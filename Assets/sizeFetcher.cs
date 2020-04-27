using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeFetcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("HomeZoneSize") == "s")
        {
            this.gameObject.transform.localScale = new Vector3(.7f, .8f, .7f);
        }
        else if(PlayerPrefs.GetString("HomeZoneSize") == "l")
        {
            this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (PlayerPrefs.GetString("HomeZoneSize") == "2xl")
        {
            this.gameObject.transform.localScale = new Vector3(1.3f, 1f, 1.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
