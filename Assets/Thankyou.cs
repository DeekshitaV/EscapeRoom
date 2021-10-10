using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Thankyou : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "ThankyouVideo.mp4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
