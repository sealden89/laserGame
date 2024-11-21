using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class particleSpawnScript : MonoBehaviour
{

    public static float initialX = 0.0F;
    public static float initialY = 4.0F;
    public static float initialZ = 0.0F;

    public Vector3 origin = new Vector3(initialX,initialY,initialZ);
    public float radius = 0.5F;
    public GameObject Particle;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<1000;i++)
        {
            SpawnParticle(origin + Random.insideUnitSphere * radius);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnParticle(Vector3 placement)
    {
        Instantiate(Particle, placement, transform.rotation);
    }

}
