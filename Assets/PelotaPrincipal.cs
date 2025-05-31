using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaPrincipal : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private int cuenta = 0;
    // Start is called before the first frame update
    void Start()
    {

        rb.GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Finish"))
        {
            print("Total de puntos: " + cuenta);
        }

        if (collider.gameObject.CompareTag("ChekPoint"))
        {
            cuenta = +1;
        }

    }
}
