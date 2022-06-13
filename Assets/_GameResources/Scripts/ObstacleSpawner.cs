using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    // ------------------------------------- position of block
    private int[] RandomPosition = {-4,0,4};
    // ------------------------------------- spawnned blocks
    [SerializeField]private List<GameObject> spawnnedchilds;
    void Start()
    {
        // --------------------------------- repeating block spawning
        InvokeRepeating("Spawn",2f,2f);
        // --------------------------------- to ignore the error of list
        spawnnedchilds.Add(this.gameObject);
    }
    // ------------------------------------- block spawning
    private void Spawn() 
    {
        GameObject newInstace = Instantiate(Cube);
        // --------------------------------- random number from the RandomPosition list
        int RandomPosX = Random.Range(0,RandomPosition.Length);
        spawnnedchilds.Add(newInstace);
        // --------------------------------- Setting the position
        newInstace.transform.localPosition = new Vector3(RandomPosition[RandomPosX], this.transform.localPosition.y + spawnnedchilds[spawnnedchilds.IndexOf(newInstace)-1].transform.localPosition.y);
    }
}
