using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressingController : MonoBehaviour
{
    public GameObject[] tops;
    public GameObject[] bottoms;
    public GameObject[] eyeWears;
    public GameObject[] shoses;
    public GameObject[] menus;
    int lastTop = 0;
    public void dressTop(int index)
    {
        for (int i = 0; i < tops.Length; i++)
        {
            tops[i].SetActive(false);
        }

        if (index < tops.Length && index != -1)
        {
            tops[index].SetActive(true);

        }
        if (lastTop < 4&&index >= 4)
        {
            dressBottoms(bottoms.Length);
        }
        if (lastTop >= 4&&index!=-1)
        {
            bottoms[0].SetActive(true);
        }
        lastTop = index;

    }
    public void dressBottoms(int index)
    {
        for (int i = 0; i < bottoms.Length; i++)
        {
            bottoms[i].SetActive(false);
        }
        if(index<bottoms.Length)
        bottoms[index].SetActive(true);

        if (lastTop >= 4)
        {
            dressTop(-1);
            tops[0].SetActive(true);
        }
    }
    public void dressShoses(int index)
    {
        for (int i = 0; i < shoses.Length; i++)
        {
            shoses[i].SetActive(false);
        }
        if (index < shoses.Length)
            shoses[index].SetActive(true);
    }
    public void dressEyeWears(int index)
    {
        for (int i = 0; i < eyeWears.Length; i++)
        {
            eyeWears[i].SetActive(false);
        }
        if (index < eyeWears.Length)
            if (index != -1)
            {
                eyeWears[index].SetActive(true);
            }
            
    }
    public void showMenu(int index)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
        }
        if (index < menus.Length)
            menus[index].SetActive(true);

    }
}
