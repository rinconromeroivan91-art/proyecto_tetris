using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caida : MonoBehaviour
{
    public float fallSpeed = -1f;
    private float timer;
    private bool stopped = false;

    void Update()
    {
        if (stopped) return;
        {
            
        }
        timer += Time.deltaTime;

        if (timer >= fallSpeed)
        {
            transform.position += Vector3.down;
            timer = 0;
        }

        // Movimiento lateral
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        // Rotación
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, -90);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        stopped = true;
    }
}
