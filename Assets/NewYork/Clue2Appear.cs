using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue2Appear : MonoBehaviour
{
    public MouseLook mouseLook;
    [SerializeField]
    private Image clue2Img;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mouseLook.enabled = false;
            clue2Img.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mouseLook.enabled = true;
            clue2Img.enabled = false;
        }
    }
}
