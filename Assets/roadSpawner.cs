using UnityEngine;
using System.Collections.Generic;

public class roadSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float Zoffset;

    private bool spawned;

	void Start()
	{
	
	}
	
	void Update()
	{
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (spawned)
            return;

        var go = Instantiate(prefab) as GameObject;
        go.transform.position = transform.position + new Vector3(0,0,Zoffset);
        spawned = true;
    }
}
