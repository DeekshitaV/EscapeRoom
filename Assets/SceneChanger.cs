using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneChange();
        }
    }

    private void SceneChange()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i+1);
    }
}
