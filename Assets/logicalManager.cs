using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class logicalManager : MonoBehaviour
{
    public int numberNeutrals = 0;
    public TextMeshProUGUI numberText;
    public GameObject neutral;
   public void spawnNeutrals(Vector3 coordinates)
   {
        Instantiate (neutral,coordinates, Random.rotation); 
        numberNeutrals+=1;
        numberText.text="Neutrals="+numberNeutrals.ToString();
        Debug.Log("current position " + coordinates);
   }

   void Update()
   {
        if(Input.GetKeyDown(KeyCode.R))
        {
            numberNeutrals=0;
            numberText.text="Neutrals=0";

        }
   }
}
