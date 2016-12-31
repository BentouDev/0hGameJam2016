using UnityEngine;
using System.Collections.Generic;

public class hipek : MonoBehaviour
{
	void Start()
	{
	
	}
	
	void Update()
	{
	
	}

    void OnCollisionEnter(Collision co)
    {
        var g = co.gameObject.GetComponent<game>();
        if (g)
        {
            g.getAPoint();
            DestroyObject(gameObject);
        }
    }
}
