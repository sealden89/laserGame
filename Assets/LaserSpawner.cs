using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject laser; 

    float OffsetX = 10.56F;
    float OffsetY = 4.0F;

    float OffsetZ = 0F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {OffsetY+=0.1F;}

        if(Input.GetKeyDown("down"))
        {OffsetY-=0.1F;}

        if(Input.GetKeyDown("space"))
        {
            SpawnLaser();
        }
    }

    void SpawnLaser()
    {
        Vector3 coordinates = new Vector3(OffsetX,OffsetY,OffsetZ);

        Quaternion rotation = Quaternion.AngleAxis(90, Vector3.forward);

        Instantiate(laser, coordinates,rotation);
        Debug.Log(coordinates);
    }
}

