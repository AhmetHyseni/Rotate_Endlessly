using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject[] spawnablebuildings;

    // Start is called before the first frame update
    void Start()
    {
        int temp_Number = Random.Range(0, (spawnablebuildings.Length-1));
        spawnablebuildings[temp_Number].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
