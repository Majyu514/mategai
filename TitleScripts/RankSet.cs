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
            Debug.Log("��ʂ��Z�b�g");
        }
        else
        {
            PlayerPrefs.SetFloat("No1", 0);
                PlayerPrefs.Save();
        }

        if (PlayerPrefs.HasKey("No2"))
        {
            Debug.Log("��ʂ��Z�b�g");
        }
        else
        {
            PlayerPrefs.SetFloat("No2", 0);
            PlayerPrefs.Save();

        }

        if (PlayerPrefs.HasKey("No3"))
        {
            Debug.Log("�O�ʂ��Z�b�g");
        }
        else
        {
            PlayerPrefs.SetFloat("No3", 0);
                PlayerPrefs.Save();
            
        }

        if (PlayerPrefs.HasKey("No4"))
        {
            Debug.Log("�l�ʂ��Z�b�g");
        }
        else
        {
            PlayerPrefs.SetFloat("No4", 0);
                PlayerPrefs.Save();
            
        }

        if (PlayerPrefs.HasKey("No5"))
        {
            Debug.Log("�܈ʂ��Z�b�g");
        }
        else
        {
            PlayerPrefs.SetFloat("No5", 0);
                PlayerPrefs.Save();
        }
    }

}
