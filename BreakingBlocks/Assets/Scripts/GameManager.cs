using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
     public Transform ball;//Ball transformu

     public Transform cam;//Main Camera transformu

     private int activeSceneIndex;


    private void Start()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;//Mevcut sahnemix index'ini oluşturduğumuz değişkene atadık.
    }

    void Update()
    {
        CheckBallPos();
        AfterScene();
    }

    private void CheckBallPos()//Ball'ın pozisyonunu kontrol edeceğimiz fonksiyon
    {
        if (ball.position.y <= cam.position.y -7f)//Topun y pozisyonu cameranın y pozisyonunun -7f'ine küçük eşit ise;
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Aktif olan sahneyi tekrar yükle
        }
    }


    public void AfterScene()//Sonraki sahneye geçeceğimiz fonksiyon
    {
        if (BlockController.blockNumbers <= 0 )//blockNumbers 0'a küçük eşit ise;
        {
            SceneManager.LoadScene(activeSceneIndex +1) ;//Diğer sahneye geç
        }
    }
}
