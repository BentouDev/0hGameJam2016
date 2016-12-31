using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Image img;
    public Text points;
    private Rigidbody body;
    public float Acceleration = 1;
    public float TopSpeed = 6;
    public float rotateSpeed = 30.0f;

    public float hitTime;
    public float timeGain;

    private float timeLeft;

    private float currentVelocity;
    private float startY;
    private int point;

	void Start()
	{
	    body = GetComponent<Rigidbody>();
	    startY = transform.position.y;
	    timeLeft = hitTime;
	}
	
	void Update()
	{
	    var x = Input.GetAxis("Horizontal");
	    var y = Input.GetAxis("Vertical");

	    timeLeft -= Time.deltaTime;
        img.fillAmount = timeLeft / hitTime;

        currentVelocity += Acceleration * y * Time.deltaTime;
	    currentVelocity = Mathf.Clamp(currentVelocity, -TopSpeed, TopSpeed);
        transform.position += y * transform.forward * currentVelocity * Time.deltaTime;
        transform.position = new Vector3
        (
            transform.position.x,
            startY,
            transform.position.z
        );
        
        transform.Rotate(0, rotateSpeed * x * Time.deltaTime, 0);
        body.velocity = new Vector3();

	    if (timeLeft <= 0)
	    {
	        Application.Quit();
	    }
	}

    public void getAPoint()
    {
        point ++;
        points.text = "POINTS : " + point.ToString();
        timeLeft += timeGain;
        timeLeft = Mathf.Clamp(timeLeft, 0, hitTime);
    }
}
