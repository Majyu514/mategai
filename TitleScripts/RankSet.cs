using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("No1"))
        {
            Debug.Log("一位をセット");
        }
        else
        {
            PlayerPrefs.SetFloat("No1", 0);
                PlayerPrefs.Save();
        }

        if (PlayerPrefs.HasKey("No2"))
        {
            Debug.Log("二位をセット");
        }
        else
        {
            PlayerPrefs.SetFloat("No2", 0);
            PlayerPrefs.Save();

        }

        if (PlayerPrefs.HasKey("No3"))
        {
            Debug.Log("三位をセット");
        }
        else
        {
            PlayerPrefs.SetFloat("No3", 0);
                PlayerPrefs.Save();
            
        }

        if (PlayerPrefs.HasKey("No4"))
        {
            Debug.Log("四位をセット");
        }
        else
        {
            PlayerPrefs.SetFloat("No4", 0);
                PlayerPrefs.Save();
            
        }

        if (PlayerPrefs.HasKey("No5"))
        {
            Debug.Log("五位をセット");
        }
        else
        {
            PlayerPrefs.SetFloat("No5", 0);
                PlayerPrefs.Save();
        }
    }

}
