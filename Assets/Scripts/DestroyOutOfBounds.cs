using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xPosLim = 150;
    private float xNegLim = -150;
    private float zPosLim = 150;
    private float zNegLim = -150;
    
    void Update()
    {
        //Limite de la posicion X en el que se destruira
        if (transform.position.x > xPosLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < xNegLim)
        {
            Destroy(gameObject);
        }

        //Limite de la posicion Z en el que se destruira
        if (transform.position.z > zPosLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < zNegLim)
        {
            Destroy(gameObject);
        }

    }
}
