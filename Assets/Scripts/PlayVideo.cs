using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public GameObject CanvasVideo, Tumbnail, PlayBtn, PauseBtn;
    public VideoPlayer Video;

    public void PlayingVideo()
    {
        CanvasVideo.SetActive(true);
        PlayBtn.SetActive(true);
        Tumbnail.SetActive(true);
        PauseBtn.SetActive(false);
        
    }

    public void StopVideo()
    {
        Video.Stop();
    }
}
