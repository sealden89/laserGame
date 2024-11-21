using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class particleMove : MonoBehaviour
{
    // Start i    public

    public logicalManager logic;

    public float movespeed = 5;
    public float deadZone = 12;

    float elapsedTime = 0;

    SphereCollider col;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("overlap").GetComponent<logicalManager>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
    
        elapsedTime += Time.deltaTime;
        float yOscillations = HarmonicMotion(elapsedTime,0.1F,15);
        float currentZ = transform.position.z;
        transform.position = transform.position + UnityEngine.Vector3.forward*movespeed*Time.deltaTime;

        if(transform.position.z> deadZone)
        {
            Destroy(gameObject);
        }

        
    }
    float HarmonicMotion(float t,float A,float omega)
    {   
        return A*MathF.Cos(omega*t);
    
    }


     private void OnTriggerEnter(Collider other)
     {
        
        logic.spawnNeutrals(transform.localPosition);
     }

}
