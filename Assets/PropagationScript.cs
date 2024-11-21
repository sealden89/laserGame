using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropagationScript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadZone = 12;
    //spwn at -12
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
        
        transform.position = transform.position + new UnityEngine.Vector3 (0,0,movespeed*Time.deltaTime);
    }
}
