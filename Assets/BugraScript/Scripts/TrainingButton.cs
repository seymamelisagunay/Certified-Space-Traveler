using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button TrainingButton;

    void Start()
    {
        TrainingButton.onClick.AddListener(PlayVideo);
    }

    void PlayVideo()
    {
        videoPlayer.url = "Assets/BugraScript/VideoPictures/BlasterTraining.mp4.mp4";
        videoPlayer.Play();
    }
}
