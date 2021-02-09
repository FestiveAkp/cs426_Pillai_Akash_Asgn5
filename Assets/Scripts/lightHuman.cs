using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightHuman : MonoBehaviour
{
    public Light myLight;

    void Start()
    {
        myLight = myLight.GetComponent<Light>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            print("Cat lightswitch activated");
            myLight.enabled = true;
        }
    }
}
