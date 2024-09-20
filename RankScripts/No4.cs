using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No4 : MonoBehaviour
{
    public Text Scoretext;
    float forth ;

    void Start()
    {
        forth = PlayerPrefs.GetFloat("No4", 0);
        Scoretext.text = "" + forth;
    }

}
