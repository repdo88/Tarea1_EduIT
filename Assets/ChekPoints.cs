using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoints : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public Transform plano;

    private float limIzquierda;
    private float limDerecha;
    private float ancho;
    // Start is called before the first frame update
    void Start()
    {
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        Vector3 pos = this.transform.position;
        pos.z = Mathf.Clamp(pos.z, limIzquierda, limDerecha);
        this.transform.position = pos;
    }
}
