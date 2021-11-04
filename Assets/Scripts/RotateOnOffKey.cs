using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnOffKey : MonoBehaviour
{
    private bool active = false;
    public string keyPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPressed))
        {
            active = !active;
        }

        if (active)
        {
            transform.Rotate(new Vector3(0, 5, 0) * Time.deltaTime);
        }
    }
}
