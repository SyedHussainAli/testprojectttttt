using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hussain : MonoBehaviour
{
    int speed=30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float ver = Input.GetAxis("Horizontal");
       
        transform.Translate(Vector3.right * speed * Time.deltaTime*ver);

    }
}
