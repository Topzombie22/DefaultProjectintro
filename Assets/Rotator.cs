using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Rotate(Vector3.up * 270 * Time.deltaTime);
        gameObject.transform.Rotate(Vector3.right * 180 * Time.deltaTime);
        GetComponent<Renderer>().material.color = new Color(100, 255, 0);
        GetComponent<Renderer>().material.color = new Color(200, 0, 0);
    }
}