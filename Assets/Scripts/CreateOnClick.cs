using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float distance;

    public GameObject initialObject;
    public GameObject objectCopy;

    private void Awake()
    {
        if (!_camera) _camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectCopy.GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
            GameObject clone;
            //clone = Instantiate(objectCopy, transform.position, transform.rotation);
            clone = Instantiate(objectCopy, _camera.transform.position + _camera.transform.forward * distance, _camera.transform.rotation);
        }
      
    }
}
