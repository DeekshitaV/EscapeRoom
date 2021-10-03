using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Temple
{
    public class textInput : MonoBehaviour
    {
        public MouseLook mouse;

        public string[] answers;
        public InputField[] inputField;

        public GameObject[] doors;
        public GameObject[] DoorImg;

        public AudioSource Correct;
        public AudioSource Incorrect;
        int door;

        private void Start()
        {
            door = 0;
        }

        public void OnClickClue()
        {
            if (door == 0)
                OnClickClue1();
            else if (door == 1)
                OnClickClue2();
            else if (door == 2)
                OnClickClue3();
            else OnClickClue4();
        }
        public void OnClickClue1()
        {
           
                if (inputField[0].text == answers[0])
                {
                    Correct.Play();
                    doors[0].SetActive(false);
                    DoorImg[0].SetActive(false);
                    inputField[0].text = "";
                    mouse.enabled = true;
                    Cursor.visible = false;
                    door++;
                //  return;
            }
                else
                {
                    Incorrect.Play();
                }
                Debug.Log(door);
               
        }
        public void OnClickClue2()
        {
            
            if (inputField[1].text == answers[1])
            {
                Correct.Play();
                doors[1].SetActive(false);
                DoorImg[1].SetActive(false);
                inputField[1].text = "";
                mouse.enabled = true;
                Cursor.visible = false;
                door++;
                //  return;
             }
            else
            {
                Incorrect.Play();
            }
            Debug.Log(door);           
            
        }
        public void OnClickClue3()
        {
            
            if (inputField[2].text == answers[2])
            {
                Correct.Play();
                doors[2].SetActive(false);
                DoorImg[2].SetActive(false);
                inputField[2].text = "";
                mouse.enabled = true;
                Cursor.visible = false;
                door++;
                //  return;
            }
            else
            {
                Incorrect.Play();
            }
            Debug.Log(door);     
            
        }
        public void OnClickClue4()
        {
           
            if (inputField[3].text == answers[3])
            {
                Correct.Play();
                doors[3].SetActive(false);
                DoorImg[3].SetActive(false);
                inputField[3].text = "";
                mouse.enabled = true;
                Cursor.visible = false;
                //    return;
            }
            else
            {
                Incorrect.Play();
            }
            Debug.Log(door);
        }   
    }

}
