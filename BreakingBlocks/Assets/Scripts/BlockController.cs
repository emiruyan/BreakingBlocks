 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private int health;

    private void OnCollisionEnter2D(Collision2D col)
    {
        health--; //Her çarptığında bir bir azalsın
        if (health <= 0) //health 0'a küçük eşit ise;
        {
            Destroy(gameObject);//Bu gameObject'i yok et
        }
    }
}
