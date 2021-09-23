using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceCodes
{
    public class door1 : MonoBehaviour
    {
        [SerializeField] private Animator MyAnimationController;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                MyAnimationController.SetBool("playopen", true);
        }
    }

}

