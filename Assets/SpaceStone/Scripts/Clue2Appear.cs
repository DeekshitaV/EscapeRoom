using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceCodes
{
    public class Clue2Appear : MonoBehaviour
    {
        public MouseLook mouse;
        [SerializeField]
        private Image clue2Img;
        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                clue2Img.enabled = true;
                mouse.enabled = false;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                clue2Img.enabled = false;
                mouse.enabled = true;
            }
        }
    }
}

