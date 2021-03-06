using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonTrigger1 : MonoBehaviour
{
public InputField answer;
    public string actualAns;
    public GameObject door;
    public MouseLook mouse;
    public GameObject door2img;
    public AudioSource Door1_3;
    public AudioSource Correct;
    public AudioSource Incorrect;
       

    //  [SerializeField] private Animator MyAnimationController;
    string input;

    public void onSubmit()
    {
        input = answer.text; 
        if (input.ToUpper() == actualAns.ToUpper())
        {
            Correct.Play();
            door.SetActive(false);
            door2img.SetActive(false);
            Debug.Log("You did it!");
            // MyAnimationController.SetBool("open", true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            mouse.enabled = true;
            Door1_3.Play();
        }
        else
        {
            Debug.Log(input.ToUpper());
            Debug.Log(actualAns.ToUpper());
            Incorrect.Play();
        }
    }

}


