using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Start is called before the first frame update    public logicalManager logic;
    // Start is called before the first frame update
    public logicalManager logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("overlap").GetComponent<logicalManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
     {
        Debug.Log("collision");
     }
}

