using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitScript : MonoBehaviour
{
    public Renderer RD;
    public Material MM;


    // Start is called before the first frame update
    void Start()
    {
        MM.SetFloat("_Vector1", 1f);
        // Debug.Log(RD.material.name);
        RD.material.SetFloat("_Vector1", 1);
    }

    void Update()
    {
        // Debug.Log(RD.material.GetFloat("_Vector1"));
    }
}
