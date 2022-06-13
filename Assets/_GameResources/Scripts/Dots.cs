using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dots : MonoBehaviour
{
    [SerializeField] private Controller dotcontroller;
    private void OnCollisionEnter(Collision collision)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Debug.Log("loss");
            dotcontroller.isdead = true;
        }
    }
}
