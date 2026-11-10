using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class CamaraController : MonoBehaviour 
{ 
    //Obtener el jugador 
    public GameObject jugador;//lo declaramos 

    //para guardar la diferencia entre la posición de la camara y el 
    //jugador 
    private Vector3 offset; 

    // Start is called before the first frame update 
    void Start() 
    { 
        //calculado diferencia a la camara le restamos la posición del 
        //jugador 
        offset = transform.position - jugador.transform.position; 
    } 

    // Update is called once per frame 
    void Update() 
    { 

    } 

    //Se ejecuta cada frame despues de haber procesado todo, es mejor 
    //para la camara 
    private void LateUpdate() 
    { 
        //Actualizando la posición de la camara 
        transform.position = jugador.transform.position + offset; 
    } 
}