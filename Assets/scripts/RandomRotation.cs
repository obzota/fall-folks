using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(Random.Range(0,90), Random.Range(0,90), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
