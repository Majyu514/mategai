using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No3 : MonoBehaviour
{
    public Text Scoretext;
    float third ;

    void Start()
    {
        third = PlayerPrefs.GetFloat("No3", 0);
        Scoretext.text = "" + third;
    }

    
}
