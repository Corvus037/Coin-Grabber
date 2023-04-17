using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Infinity : MonoBehaviour
{
    private float h;
    public float moveSpeed;
    public int Points;

    public Text Score;
    public Vector3 limitPosition;

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * h * Time.deltaTime * moveSpeed;

        // Verifica se o jogador chegou na posição limite à esquerda
        if (transform.position.x < limitPosition.x)
        {
            // Impede o jogador de se mover mais para a esquerda
            transform.position = new Vector3(limitPosition.x, transform.position.y, transform.position.z);
        }

        // Verifica se o jogador chegou na posição limite à direita
        if (transform.position.x > limitPosition.y)
        {
            // Impede o jogador de se mover mais para a direita
            transform.position = new Vector3(limitPosition.y, transform.position.y, transform.position.z);
        }
    }

    void OnCollisionEnter(Collision coin_01)
    {
        Points = Points + 1;
        Score.text = "Score: " + Points;

        
    }
}
