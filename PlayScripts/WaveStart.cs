using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class WaveStart : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.targetTexture.Release();
        this.videoPlayer.Stop();
        StartCoroutine(Wave());
    }

    IEnumerator Wave()
    {
        yield return new WaitForSeconds(52);
        this.videoPlayer.Play();
        yield return new WaitForSeconds(8);
    }

}
