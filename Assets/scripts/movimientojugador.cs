using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    private Rigidbody2D rb;
    public bool puedoSaltar = true; // Control de salto

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimiento = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) movimiento = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) movimiento = 1f;

        transform.Translate(Vector2.right * movimiento * velocidad * Time.deltaTime);

        // Ahora comprobamos que se pulse la flecha Y que estemos en el suelo
        if (Input.GetKeyDown(KeyCode.UpArrow) && puedoSaltar)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            puedoSaltar = false; // Bloqueamos el salto hasta tocar suelo otra vez
        }
    }

    // Se activa cuando el dinosaurio choca con algo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            puedoSaltar = true;
        }
    }
}