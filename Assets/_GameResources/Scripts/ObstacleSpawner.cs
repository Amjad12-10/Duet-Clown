using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    private int[] RandomPosition = {-4,0,4};
    private int spawnnumber;

    [SerializeField]private List<GameObject> spawnnedchilds;
    void Start()
    {
        InvokeRepeating("Spawn",2f,2f);
        spawnnedchilds.Add(this.gameObject);
    }
    private void Spawn() 
    {
        GameObject newInstace = Instantiate(Cube);
        int RandomPosX = Random.Range(0,RandomPosition.Length);
        spawnnumber++;
        spawnnedchilds.Add(newInstace);
        newInstace.transform.localPosition = new Vector3(RandomPosition[RandomPosX], this.transform.localPosition.y + spawnnedchilds[spawnnedchilds.IndexOf(newInstace)-1].transform.localPosition.y);
        //Destroy(newInstace, 5);
    }
}
