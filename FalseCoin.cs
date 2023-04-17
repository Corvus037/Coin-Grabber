using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FalseCoin : MonoBehaviour
{
    public int Life = 4;
    public Text Vidas;
    public float Speed;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Life--;
            Vidas.text = "Lifes: " + Life;
            if (Life < 1)
            {
                SceneManager.LoadScene("GameOver");
            }
            float x = Random.Range(-10, 19);
            float y = Random.Range(63, 64);
            Vector3 pos = new Vector3(x, y, 12);
            transform.position = pos;
        }
        else if (col.gameObject.tag == "Floor")
        {
            float x = Random.Range(-10, 19);
            float y = Random.Range(63, 64);
            Vector3 pos = new Vector3(x, y, 12);
            transform.position = pos;
        }
    }
}
