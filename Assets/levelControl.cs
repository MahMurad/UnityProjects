using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelControl : MonoBehaviour
{
  
    void OnTriggerEnter()
    {
        {
            SceneManager.LoadScene(1);
        }
    }
}