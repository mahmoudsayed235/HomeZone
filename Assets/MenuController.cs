using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject back;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void chooseGender(string gender)
    {


        next.SetActive(true);
        this.gameObject.SetActive(false);

        PlayerPrefs.SetString("HomeZoneGender", gender);
     }
    public void chooseSize(string size)
    {


        next.SetActive(true);
        this.gameObject.SetActive(false);
        PlayerPrefs.SetString("HomeZoneSize", size);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            back.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
    public void openScene(bool vr)
    {
        if (PlayerPrefs.GetString("HomeZoneGender") == "f")
        {
            if (vr)
            {
                StartCoroutine(SwitchToVR("girlVR"));
            }
            else
            {
                SceneManager.LoadScene("girlInteractive");

            }
        }
        else
        {
            if (vr)
            {
                StartCoroutine(SwitchToVR("boyVR"));
            }
            else
            {
                SceneManager.LoadScene("boyInteractive");

            }
        }
    }
    IEnumerator SwitchToVR(string sceneName)
    {
        // Device names are lowercase, as returned by `XRSettings.supportedDevices`.
        // Google original, makes you specify
        //string desiredDevice = "daydream"; // Or "cardboard".
        //XRSettings.LoadDeviceByName(desiredDevice);
        // this is slightly better;
        string[] DaydreamDevices = new string[] { "daydream", "cardboard" };
        XRSettings.LoadDeviceByName(DaydreamDevices);

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Now it's ok to enable VR mode.
        XRSettings.enabled = true;
        SceneManager.LoadScene(sceneName);
    }

}
