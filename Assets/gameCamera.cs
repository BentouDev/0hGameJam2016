using UnityEngine;
using System.Collections.Generic;

public class gameCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float Speed = 24;

	void Start()
	{
        offset = transform.position - target.position;
	}
	
	void Update()
	{
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * Speed);
	}
}
