using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No5 : MonoBehaviour
{
    public Text Scoretext;
    float fifth ;

    void Start()
    {
        fifth = PlayerPrefs.GetFloat("No5", 0);
        Scoretext.text = "" + fifth;
    }

   
}
