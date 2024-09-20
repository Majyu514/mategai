using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No1 : MonoBehaviour
{
    public Text Scoretext;
    float first;

    void Start()
    {
        first = PlayerPrefs.GetFloat("No1", 0);
        Scoretext.text =""+ first;
    }

    
}
