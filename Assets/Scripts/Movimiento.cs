using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Paso 58: Necesario para controlar textos de la interfaz[cite: 15, 16]

public class movimiento : MonoBehaviour 
{ 
    private Rigidbody rb;
    private float velocidad = 10;
    
    private int contador_coleccionables = 0; // Paso 51: Inicia el contador[cite: 14, 16]
    public Text puntaje; // Paso 59: Variable pública para arrastrar el Texto UI desde el Inspector[cite: 15, 16]

    void Start() 
    { 
        rb = GetComponent<Rigidbody>(); 
    } 

    void Update() 
    { 

    } 

    private void FixedUpdate() 
    { 
        float movimientoH = Input.GetAxis("Horizontal"); 
        float movimientoV = Input.GetAxis("Vertical"); 

        // Vector de dirección sin el "* 10" fijo, para respetar la variable velocidad[cite: 9, 16]
        Vector3 dirMovimiento = new Vector3(movimientoH, 0.0f, movimientoV); 
        
        // Multiplicamos por la variable 'velocidad' al añadir la fuerza[cite: 9, 16]
        rb.AddForce(dirMovimiento * velocidad); 
    } 

    // Pasos 52 y 60: Método que se ejecuta al chocar con un objeto "Is Trigger"[cite: 14, 16]
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto tocado tiene el Tag correcto[cite: 14, 16]
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false); // Hace desaparecer el cubo[cite: 14, 16]
            Debug.Log("Recogidos: " + ++contador_coleccionables); // Muestra en consola[cite: 14, 16]
            puntaje.text = contador_coleccionables + ""; // Actualiza el número en la pantalla del juego[cite: 15, 16]
        }
    }
}