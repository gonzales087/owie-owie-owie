using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ModuleOne : MonoBehaviour
{

    public VideoPlayer moduleOneVideo;

    private void Awake()
    {

        moduleOneVideo = GetComponent<VideoPlayer>();
    }

    public void PlayVideo()
    {


        moduleOneVideo.Play();
    }

    public void PauseVideo()
    {

        moduleOneVideo.Pause();
    }
}
