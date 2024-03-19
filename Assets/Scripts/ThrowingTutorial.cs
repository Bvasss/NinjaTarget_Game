using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ThrowingTutorial : MonoBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform attackPoint;
    public GameObject objectToThrow;

    [Header("Settings")]
    public int totalThrows;
    public float throwCooldown;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    [Header("txt")]
    public Text textoI;
    public Text textoA;
    public Text textoF;

    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
        throwForce = 0;
        throwUpwardForce = 0;
    }

    private void Update()
    {
        textoI.text = totalThrows.ToString();
        textoA.text = throwUpwardForce.ToString();
        textoF.text = throwForce.ToString();
    

        if (Input.GetKeyDown(KeyCode.R))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

       if(Input.GetKeyDown(KeyCode.E))
        {
            throwForce = throwForce -5;
        }

         if(Input.GetKeyDown(KeyCode.Q))
        {
            throwForce = throwForce +5;
        }

       if(Input.GetKeyDown(KeyCode.Z))
        {
            throwUpwardForce = throwUpwardForce -5;
        }

         if(Input.GetKeyDown(KeyCode.X))
        {
            throwUpwardForce = throwUpwardForce +5;
        }

        if(Input.GetKeyDown(throwKey) && readyToThrow && totalThrows > 0)
        {
            Throw();
        }
        
    }

    private void Throw()
    {
        readyToThrow = false;

        // instantiate object to throw
        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation);

        // get rigidbody component
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        // calculate direction
        Vector3 forceDirection = cam.transform.forward;

        RaycastHit hit;

        if(Physics.Raycast(cam.position, cam.forward, out hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }

        // add force
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        totalThrows--;

        


        // implement throwCooldown
        Invoke(nameof(ResetThrow), throwCooldown);
    }

    private void ResetThrow()
    {
        readyToThrow = true;
    }
}