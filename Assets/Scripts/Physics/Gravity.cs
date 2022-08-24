using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Planet.planet.objects.Add(GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
