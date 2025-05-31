using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaPrincipal : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private int cuenta = 0;

    // aca limito el movimiento de la pelota
    public Transform plano;

    private float limIzquierda;
    private float limDerecha;
    private float ancho;
    // Start is called before the first frame update
    void Start()
    {

        rb.GetComponent<Rigidbody>();

        //Aca limito el movimiento de la pelota
        Renderer planoRenderer = plano.GetComponent<Renderer>();
        float anchoPlano = planoRenderer.bounds.size.z;

        Renderer chekRenderer = GetComponent<Renderer>();
        ancho = chekRenderer.bounds.size.z / 2f;

        float centro = plano.position.z;
        limIzquierda = centro - (anchoPlano / 2f) + ancho;
        limDerecha = centro + (anchoPlano / 2f) - ancho;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
        }

        //Aca limito el movimiento de la pelota
        Vector3 pos = this.transform.position;
        pos.z = Mathf.Clamp(pos.z, limIzquierda, limDerecha);
        this.transform.position = pos;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("ChekPoint"))
        {
            print("Acertaste");
            cuenta += 1;
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.CompareTag("Finish"))
        {
            print("Total de puntos: " + cuenta);
            Destroy(gameObject);
        }



    }
}
