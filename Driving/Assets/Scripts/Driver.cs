using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{


    [SerializeField] private float steerSpeed = 1f;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float fastSpeed = 50f;


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = fastSpeed;
        }

        if(other.tag == "Slow")
        {
            moveSpeed = slowSpeed;
        }
    }
    
    void Update()
    {
        float steerAmountH = Input.GetAxis(axisName: "Horizontal") * steerSpeed * Time.deltaTime;
        float steerAmountV = Input.GetAxis(axisName: "Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(xAngle: 0, yAngle: 0, zAngle: -steerAmountH);
        transform.Translate(x: 0, y: steerAmountV, z: 0);
        

    }
}
