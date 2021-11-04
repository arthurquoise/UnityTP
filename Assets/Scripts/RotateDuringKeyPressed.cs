using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{

    public string keyPressed;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Rotate()
    {
        transform.Rotate(new Vector3(0, 5, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPressed))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
    }
}
