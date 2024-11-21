using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neutralMove : MonoBehaviour
{
    // Start is called before the first frame update    public logicalManager logic;

    
    float movespeed = 6;
    public float deadZone = 12;

    float elapsedTime = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
        elapsedTime += Time.deltaTime;
        //transform.position+= new Vector3 (0,0,speed*Time.deltaTime);
        transform.position = transform.position + UnityEngine.Vector3.forward*movespeed*Time.deltaTime;
        Debug.Log(Time.deltaTime);
        Debug.Log(UnityEngine.Vector3.forward*movespeed*Time.deltaTime);
        
        if(transform.position.z> deadZone)
        {
            Destroy(gameObject);
        }
        
    }


}
