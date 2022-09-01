 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int health;
    public static int blockNumbers;//bu değişken bir kez çalışacak
    public bool breakingBlocks;
    private GameManager gm;

    private void Start()
    { 
        breakingBlocks = (tag == "Block");//"Block" tagını breakingBlocks'a atadık
        
        if (breakingBlocks)  
        {
            blockNumbers++;//blockNumbers'ı bir bir arttır
        }

        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        health--; //Her çarptığında bir bir azalsın
        if (health <= 0) //health 0'a küçük eşit ise;
        {
            blockNumbers -= 1;//Blok sayımız bir azalsın 
            Destroy(gameObject);//Bu gameObject'i yok et
            gm.AfterScene();//Game Manager içerisindeki AfterScene methodunu çalıştır
        }
        
    }
}
