using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiScript : MonoBehaviour
{
   
     public void BtnClick()
    {
        SceneManager.LoadScene("Game");
    }

     
}
