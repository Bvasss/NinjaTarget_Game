using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        onGround = false;
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Este objeto no tiene un Rigidbody adjunto.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Detener()
    {
        rb.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision c){
        Debug.Log("Colision");
        onGround = true;
    }
    private void OnCollisionStay(Collision c){

        onGround = true;
    }
    private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
