using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Temple
{
    public class NoteAppear : MonoBehaviour
    {
        [SerializeField]
        private Image _noteImage;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _noteImage.enabled = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _noteImage.enabled = false;
            }
        }
    }

}
