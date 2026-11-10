using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Rota el elemento una cantidad diferente en cada dirección y en cada 
        //intérvalo de tiempo 
        //Time.deltaTime es el tiempo transcurrido en cada frame (a 60fps, sería 
        //1/60s) 
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}