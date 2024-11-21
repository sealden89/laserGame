using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject laserPulse;


    BoxCollider col;
    float elapsedTime = 0;
    float scaleLength = 3;
    float fireSpeed = -0.05F;
    float unitIncrease=60;

    bool started = false;
    float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (!started)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                float x = laserPulse.transform.localScale.x;
                float z = laserPulse.transform.localScale.z;

                laserPulse.transform.localScale = new Vector3 (x,scaleLength*elapsedTime,z);
                col = GetComponent<BoxCollider>();
                col.size = new Vector3(col.transform.localScale.x,scaleLength*elapsedTime, col.transform.localScale.z);
                deadZone= -(10+laserPulse.transform.localScale.x);

            }
            if(!Input.GetKey(KeyCode.Space))
            {
                started=true;
            }
        }


        if(started)
        {
            laserPulse.transform.position = new Vector3 (laserPulse.transform.position.x+fireSpeed*elapsedTime,laserPulse.transform.position.y,laserPulse.transform.position.z);
        }
        
      if (transform.position.x < deadZone)
        {
            Debug.Log("pulse deleted");
            Destroy(gameObject);
        }
    }


     


}
