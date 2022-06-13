using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // ------------------------------------- block speed 
    [SerializeField] private float speed;
    // ------------------------------------- Scale X 
    [SerializeField] private float x_offset;
    private float x_scale = 4;
    private int Ran;
    void Start()
    {
         Ran = (int)Random.Range(2,4);
        transform.localScale = new Vector3(4,Ran);
    }
    void Update()
    {
        // --------------------------------- ping pong effect
        float _time = Mathf.PingPong(Time.time*speed,x_offset);
        transform.localScale = new Vector3(_time+x_scale,Ran);
    }
}
