using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CbcTorso : MonoBehaviour
{
    //Código que faz com que a cabeça e torso do PLayer se movem de acordo com o mouse.
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new(mousePosition.x - transform.position.x, mousePosition.y
        - transform.position.y);
        transform.up = direction;
    }
}
