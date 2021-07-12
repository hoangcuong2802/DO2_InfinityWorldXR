using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItself : MonoBehaviour
{
    //GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(camera.transform);
        this.transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
    }
}
