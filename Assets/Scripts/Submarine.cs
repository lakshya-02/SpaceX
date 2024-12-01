using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    [SerializeField] private float speed = 10;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Rigidbody2D.velocity = Vector2.up * speed;
        }
    }
}
