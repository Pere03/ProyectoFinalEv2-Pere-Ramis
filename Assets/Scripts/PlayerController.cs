using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeedH = 50f;
    private float turnSpeedV = 20f;
    public float horizontalInput;
    public float verticalInput;

    public GameObject missilePrefab;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Esto hace que puedas avanzar hacia delante y atras con el objeto
        transform.Translate(Vector3.forward * turnSpeedV * Time.deltaTime * verticalInput);

        //Esto hace que puedas rotar/mover hacia la izquierda y derecha con el objeto
        transform.Rotate(Vector3.up * turnSpeedH * Time.deltaTime * horizontalInput);

        //Esto hace que si pulsamos espacio, instanciara el misil
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missilePrefab.transform.rotation = gameObject.GetComponent<Transform>().rotation;

            Instantiate(missilePrefab, transform.position,
                missilePrefab.transform.rotation);
        }
    }
}
