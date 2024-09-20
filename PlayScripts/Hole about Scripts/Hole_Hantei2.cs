using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hole_Hantei2 : MonoBehaviour
{
    public Spawner2 spawner1;
    private bool Fever = false;

    void Start()
    {
        StartCoroutine(Bonus());
    }
    // Update is called once per frame
    void Update()
    {
        if (spawner1.S1 == false || Fever)
        {
            gameObject.GetComponent<Image>().color = new Color(0.8f, 0.3f, 0.1f, 0.0f);
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }

    IEnumerator Bonus()
    {
        yield return new WaitForSeconds(60);
        Fever = true;
    }
}
