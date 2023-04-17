using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed;
      void OnCollisionEnter(Collision outro)
    {
       float x = Random.Range (-10,19);
         float y = Random.Range(63,64);
        
        Vector3 pos = new Vector3 (x,y,12);
        transform.position = pos;
    }

    
    
}
