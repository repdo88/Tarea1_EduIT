using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    [SerializeField] private Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        ren = GameObject.Find("Meta").GetComponent<Renderer>();
        ren .enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
