using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;//Rigidbody'e eriştik.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rb değişkenini Rigidbody componentine atadık.
        rb.AddForce(Vector3.up * 300f);//Ball Rigidbody'sine yukarı doğru 300f'lik bir güç ekledik. 
    }
}
