using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No2 : MonoBehaviour
{
    public Text Scoretext;
    float second ;

    void Start()
    {
        second = PlayerPrefs.GetFloat("No2", 0);
        Scoretext.text = "" + second;
    }

    
}
