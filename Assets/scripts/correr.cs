using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correr : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal"); 

        transform.Translate(Vector2.right * movimiento * velocidad * Time.deltaTime);
    }
}
