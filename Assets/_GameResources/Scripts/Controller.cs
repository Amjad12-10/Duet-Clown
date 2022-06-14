using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // ------------------------------------- rotation speed
    [SerializeField] private float Rotationspeed = 2;
    [SerializeField] private float Controllerspeed = 5;
    [SerializeField] private GameObject ControllerChild;
    // ------------------------------------- Game UI
    [SerializeField] private Text Leveltext;
    private int levelnumber;
    // ------------------------------------- Dead
    private Vector3 startposition = Vector3.zero;
    public bool isdead;
    private void Start()
    {
        levelnumber = PlayerPrefs.GetInt("level");
        Leveltext.text = "LEVEL - "+(levelnumber + 1);
    }

    void Update()
    {
        // --------------------------------- if dot,did hit
        if (!isdead)
        {
            // ----------------------------- Player inputs
            if (Input.GetMouseButton(0))
            {
                // ------------------------- Left
                if (Input.mousePosition.x < Screen.width / 2)
                {
                    ControllerChild.transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime * Rotationspeed);
                }
                // ------------------------- Right
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    ControllerChild.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime * Rotationspeed);
                }
            }
            transform.position += Vector3.up * Controllerspeed * Time.deltaTime;
        }
        // --------------------------------- if dot,do not hit
        else
        {
            var moveback = Vector3.Lerp(this.transform.position, startposition, Time.deltaTime * (Controllerspeed/5));
            transform.position = moveback;
            ControllerChild.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime * Rotationspeed);
            if (transform.position == startposition || transform.position.y<1)
            {
                isdead = false;
            }
        }
        // --------------------------------- level complete
        if (transform.position.y > 190)
        {
            levelnumber++;
            PlayerPrefs.SetInt("level", levelnumber);
            SceneManager.LoadScene(0);
        }
    }
    
}
