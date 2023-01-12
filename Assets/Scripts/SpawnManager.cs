using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject obstablePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstablePrefab, spawnPosition, obstablePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
