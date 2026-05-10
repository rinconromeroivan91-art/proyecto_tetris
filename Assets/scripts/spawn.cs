using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Arrastra aquí el prefab del bloque o el obstáculo desde tu carpeta Assets
    public GameObject blockPrefab;

    // Tiempo inicial de espera y cada cuánto tiempo aparece uno nuevo
    public float tiempoInicial = 1f;
    public float intervalo = 3f;

    void Start()
    {
        // Llama a la función 'SpawnBlock' repetidamente
        InvokeRepeating("SpawnBlock", tiempoInicial, intervalo);
    }

    void SpawnBlock()
    {
        // Si el prefab está asignado, lo crea en la posición de este objeto (el Spawner)
        if (blockPrefab != null)
        {
            Instantiate(blockPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("¡Cuidado! No has asignado el blockPrefab en el Inspector.");
        }
    }
}