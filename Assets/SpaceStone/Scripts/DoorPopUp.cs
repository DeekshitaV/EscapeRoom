using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class DoorPopUp : MonoBehaviour
    {
        public MouseLook mouse;

        [SerializeField]
        private GameObject Door1Img;
        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                mouse.enabled = false;
                ShowCursor();
               
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                 HideCursor();
                }
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                mouse.enabled = true;
                Door1Img.SetActive(false);
                 HideCursor();
            }
        }


        public void ShowCursor()
        {

            Door1Img.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void HideCursor()
        {

           

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

