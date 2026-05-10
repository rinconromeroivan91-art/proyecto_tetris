using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoJugador : MonoBehaviour
{
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;

    private bool enSuelo = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Saltar al pulsar flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow) && enSuelo)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            enSuelo = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si toca el suelo vuelve a poder saltar
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }

}
