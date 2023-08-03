using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllar : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]float _speedWalk = 3;
    [SerializeField]float _speedRun = 5;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float _xScale = Input.GetAxisRaw("Horizontal");
        Vector2 vector2X = new Vector2 (_xScale, 0);
        _rb.velocity = vector2X * _speedWalk;
    }
}
