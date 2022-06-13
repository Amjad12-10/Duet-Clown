using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //----- rotation speed
    [SerializeField] private float Rotationspeed = 2;
    [SerializeField] private float Controllerspeed = 5;
    [SerializeField] private GameObject ControllerChild;
    //------- Dead
    private Vector3 startposition = Vector3.zero;
    public bool isdead;

    void Update()
    {
        if (!isdead)
        {
            // ---- Player inputs
            if (Input.GetMouseButton(0))
            {
                // ---- Left
                if (Input.mousePosition.x < Screen.width / 2)
                {
                    ControllerChild.transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime * Rotationspeed);
                }
                // ---- Right
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    ControllerChild.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime * Rotationspeed);
                }
            }
            transform.position += Vector3.up * Controllerspeed * Time.deltaTime;
        }
        else
        {
            var moveback = Vector3.Lerp(this.transform.position, startposition, Time.deltaTime * (Controllerspeed/2));
            transform.position = moveback;
            ControllerChild.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime * Rotationspeed);
            if (transform.position == startposition)
            {
                isdead = false;
            }

        }


    }
}
