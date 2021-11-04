using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RotateByDegrees()
    {
        Vector3 rotationToAdd = new Vector3(0, 5, 0);
        transform.Rotate(rotationToAdd);
    }

    float degreesPerSecond = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }
}
