using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform ball;//Ball transformu

    [SerializeField] private Transform cam;//Main Camera transformu
    
    void Update()
    {
        CheckBallPos();
    }

    private void CheckBallPos()//Ball'ın pozisyonunu kontrol edeceğimiz fonksiyon
    {
        if (ball.position.y <= cam.position.y -7f)//Topun y pozisyonu cameranın y pozisyonunun -7f'ine küçük eşit ise;
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Aktif olan sahneyi tekrar yükle
        }
    }
}
