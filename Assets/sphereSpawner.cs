using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereSpawner : MonoBehaviour
{

    float elapsedTime = 0;
    int count = 5;

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        spawnBunch();
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime>=count)
        {   
            spawnBunch();
            count+=5;
        }

    }

    void spawnBunch()
    {
        float rad = 3.0F;

        for(int i=0;i<1000;i++)
        {
            SpawnParticle(rad);
        }
    }
    void SpawnParticle(float radVal)
    {
        float initialX = 0.0F;
        float initialy = 4.0F;
        float initialz = -15.0F;
        Vector3 origin = new Vector3(initialX,initialy,initialz);

        Instantiate (sphere,Random.insideUnitSphere * radVal + origin,  Random.rotation);  
    }

}
