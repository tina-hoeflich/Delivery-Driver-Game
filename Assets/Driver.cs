using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 150f;
    [SerializeField] float moveSpeed = 15;
    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float fastSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
        }

    void OnTriggerEnter2D(Collider2D other) {

       if (other.tag == "Bumper") {
           Debug.Log("Bumper!");
           moveSpeed = slowSpeed;
           }
       if (other.tag == "Boost") {
           Debug.Log("Boost!");
           moveSpeed = fastSpeed;
           }
       }
}

