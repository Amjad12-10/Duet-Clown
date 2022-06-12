using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //----- rotation speed
    [SerializeField] private float Rotationspeed = 2;
    [SerializeField] private float Controllerspeed = 5;
    void Update()
    {
        // ---- Player inputs
        if (Input.GetMouseButton(0)) 
        {
            // ---- Left
            if (Input.mousePosition.x < Screen.width/2)
            {
                transform.Rotate(new Vector3(0,0,180) *Time.deltaTime* Rotationspeed);
            }
            // ---- Right
            if (Input.mousePosition.x > Screen.width / 2)
            {
                transform.Rotate(new Vector3(0,0, -180) * Time.deltaTime * Rotationspeed);
            }
        }
        transform.position += Vector3.up * Controllerspeed * Time.deltaTime;

    }
}
