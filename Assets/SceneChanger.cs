using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;
    public MouseLook mouseLook;
    public GameObject panel;
    public GameObject[] stones;
    int scene ;

    private void Start()
    {
        Cursor.visible = false;
        scene = SceneManager.GetActiveScene().buildIndex;
        foreach ( var s in stones)
        {
            s.SetActive(false);
        }
        panel.SetActive(false);
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            mouseLook.enabled = false;
            if( scene == 2)
            {
                int i = Random.Range(0, 5);
                switch (i)
                {
                    case 0: Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-a')");
                        break;
                    case 1: Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-b')");
                        break;
                    case 2: Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-c')");
                        break;
                    case 3: Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-d')");
                        break;
                    default: Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-e')");
                        break;
                }
            }
            else if( scene == 3)
            {
                int i = Random.Range(0, 5);
                switch (i)
                {
                    case 0:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-2-infinity-code-a')");
                        break;
                    case 1:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-2-infinity-code-b')");
                        break;
                    case 2:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-2-infinity-code-c')");
                        break;
                    case 3:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-2-infinity-code-d')");
                        break;
                    default:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-2-infinity-code-e')");
                        break;
                }
            }
            else if( scene == 4)
            {
                int i = Random.Range(0, 5);
                switch (i)
                {
                    case 0:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-3-infinity-code-a')");
                        break;
                    case 1:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-3-infinity-code-b')");
                        break;
                    case 2:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-3-infinity-code-c')");
                        break;
                    case 3:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-3-infinity-code-d')");
                        break;
                    default:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-3-infinity-code-e')");
                        break;
                }
            }
            else if( scene == 5)
            {
                int i = Random.Range(0, 5);
                switch (i)
                {
                    case 0:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-4-infinity-code-a')");
                        break;
                    case 1:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-4-infinity-code-b')");
                        break;
                    case 2:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-4-infinity-code-c')");
                        break;
                    case 3:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-4-infinity-code-d')");
                        break;
                    default:
                        Application.ExternalEval("window.open('https://www.hackerrank.com/room-4-infinity-code-e')");
                        break;
                }
            }
            OpenPanel();
            OnUpdate(scene - 1);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OpenPanel()
    {
        panel.SetActive(true);
        for(int i = 0; i < (scene - 1); i++)
        {
            stones[i].SetActive(true);
            
        }
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(scene+1);
    }
}
