using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PanelAppear : MonoBehaviour
{
    public GameObject help;
    public MouseLook mouse;
    public GameObject canvas;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            help.SetActive(true);
            canvas.SetActive(false);
            mouse.enabled = false;
            ShowCursor();
        }
    }
    public void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void HideCursor()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void resume()
    {
        help.SetActive(false);
        canvas.SetActive(true);
        mouse.enabled = true;
        HideCursor();
    }
}

