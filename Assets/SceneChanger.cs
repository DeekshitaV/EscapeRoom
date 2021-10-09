using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

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
            Application.ExternalEval("window.open('https://www.hackerrank.com/')");
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
