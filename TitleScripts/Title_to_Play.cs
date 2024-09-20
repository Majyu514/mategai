using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_to_Play : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("PlayScene");
    }
}