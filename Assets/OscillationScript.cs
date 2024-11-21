using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomComponent : MonoBehaviour
{    
    public float movespeed = 5;
    public float deadZone = 12;
    float elapsedTime = 0;
    float initialY = 4.0F;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > deadZone)
        {
            Debug.Log("particle deleted");
            Destroy(gameObject);
        }

        elapsedTime += Time.deltaTime;
        float yOscillations = HarmonicMotion(elapsedTime,0.1F,15);
        float currentZ = transform.position.z;
        //transform.position =  new UnityEngine.Vector3 (HarmonicMotion(elapsedTime,2,10),HarmonicMotion(elapsedTime,1,15),HarmonicMotion(elapsedTime,1,5));
        //transform.position = new UnityEngine.Vector3 (0,initialY+yOscillations, currentZ+movespeed*Time.deltaTime);
        //transform.position = new UnityEngine.Vector3 (0,0, currentZ+movespeed/100000000);
        //transform.position = transform.position + (UnityEngine.Vector3.forward*movespeed)*Time.deltaTime;

    }

    float HarmonicMotion(float t,float A,float omega)
    {   
        return A*MathF.Cos(omega*t);
    
    }

}
