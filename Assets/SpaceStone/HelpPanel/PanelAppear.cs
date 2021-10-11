using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelAppear : MonoBehaviour
{
   public GameObject help;
 // public MouseLook mouse;
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Tab)){
             help.SetActive(true);
         //   mouse.enabled = false;
                ShowCursor();
               
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    help.SetActive(false);
                 HideCursor();
                }
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
}
