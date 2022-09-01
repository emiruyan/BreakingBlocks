using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    void Update()
    {
        //mousePos isminde Vector3 değişkeni oluşturduk. Mouse koordinatı için ScreenToWorldPoint kullandık.
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x, //Mouse'umuz sadece x yönünde gideceği için bu yeterli oldu.
            transform.position.y,
            transform.position.z
            //Mouse pozisyonunu aldık.
        ));

        mousePos.x = Mathf.Clamp(mousePos.x,-2.2f, 2.2f);
        //MathfClamp ile Shooter'ın hareketini ekran içinde kalacak şekilde sınırladık.

        transform.position = new Vector3(
            mousePos.x, //Mouse pozisyonunu kullandık.
            transform.position.y,
            transform.position.z

        );
    }
}
