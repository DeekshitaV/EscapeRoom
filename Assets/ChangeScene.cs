using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public VideoPlayer videoPlayer1;
    public VideoPlayer videoPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer1.loopPointReached += activatePlayer2;
        videoPlayer2.loopPointReached += changeScene;
    }

    void activatePlayer2(UnityEngine.Video.VideoPlayer vp)
    {
        videoPlayer2.Play();
    }

    void changeScene(UnityEngine.Video.VideoPlayer vp)
    {

        SceneManager.LoadScene("Login");
    }

}



