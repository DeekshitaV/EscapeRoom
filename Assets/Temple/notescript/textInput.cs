using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Temple
{
    public class textInput : MonoBehaviour
    {

        public string[] answers;
        public InputField[] inputField;

        public GameObject[] doors;
        public GameObject[] DoorImg;



        public void OnClickClue1()
        {
            if (inputField[0].text == answers[0])
            {

                doors[0].SetActive(false);
                DoorImg[0].SetActive(false);
                inputField[0].text = "";
            }
        }
        public void OnClickClue2()
        {
            if (inputField[1].text == answers[1])
            {


                doors[1].SetActive(false);
                DoorImg[1].SetActive(false);
                inputField[1].text = "";
            }
        }
        public void OnClickClue3()
        {
            if (inputField[2].text == answers[2])
            {

                doors[2].SetActive(false);
                DoorImg[2].SetActive(false);
                inputField[2].text = "";
            }
        }
        public void OnClickClue4()
        {
            if (inputField[3].text == answers[3])
            {

                doors[3].SetActive(false);
                DoorImg[3].SetActive(false);
                inputField[3].text = "";
            }
        }


    }

}
