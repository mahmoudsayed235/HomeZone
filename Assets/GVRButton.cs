using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{

    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2f;
    bool gvrStatus;
    public float gvrTimer;

    private void Update()
    {

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            GvrOff();
            GVRClick.Invoke();
        }
    }

    public void GvrOn()
    {
        print("enter");
        gvrStatus = true;
    }

    public void GvrOff()
    {
        print("exit");
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0f;
    }


}
