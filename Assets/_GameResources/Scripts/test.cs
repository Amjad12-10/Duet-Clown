using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float x_offset;
    private float x_scale;
    // Start is called before the first frame update
    void Start()
    {
        x_scale = transform.localScale.x;

    }

    // Update is called once per frame
    void Update()
    {
        float _time = Mathf.PingPong(Time.time*speed,x_offset);
        transform.localScale = new Vector3(_time+x_scale, 1);
        Debug.Log(_time);

        transform.position -= Vector3.up * 10 * Time.deltaTime;

    }
}
