using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceCodes
{ 
public class Door4Trrigger : MonoBehaviour
{
    public InputField answer;
    public string actualAns;
    public GameObject door;
    public MouseLook mouse;
    public GameObject door4img;
    public BoxCollider box;
    string input;
 [SerializeField] private Animator MyAnimationController;
    public void onSubmit()
    {
        input = answer.text;
        if (input.ToUpper() == actualAns.ToUpper())
        {
            box.enabled = false;
             //   door.SetActive(false);
            door4img.SetActive(false);
            Debug.Log("You did it!");
            MyAnimationController.SetBool("char_nearby", true);
            MyAnimationController.SetBool("char_nearby", true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            mouse.enabled = true;
        }
        else
            Debug.Log(input.ToUpper());

    }

}
}
