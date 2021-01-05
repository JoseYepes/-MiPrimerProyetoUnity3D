using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyeMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 255, 500);
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Añade 2000de fuerza al eje z
    }
}
