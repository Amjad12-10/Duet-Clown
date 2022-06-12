using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",1.5f,1.5f);
    }
    private void Spawn() 
    {

        int RandomPosX = Random.Range(-4, 4);
        GameObject newInstace = Instantiate(Cube);
        newInstace.transform.SetParent(this.transform);
        newInstace.transform.localPosition = new Vector3(RandomPosX, 0);
        newInstace.transform.localScale = new Vector3(4,(int)Random.Range(2,10));
        Destroy(newInstace, 5);
    }
}
