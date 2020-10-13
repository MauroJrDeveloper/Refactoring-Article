using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{

    float _Speed_X = 5;
    float _Speed_Y = 5;

    Rigidbody2D _Rdb;

    Vector2 _Up_Vector;
    Vector2 _Down_Vector;
    Vector2 _Left_Vector;
    Vector2 _Right_Vector;

    void Start()
    {
        _Rdb = GetComponent<Rigidbody2D>();
        _Up_Vector = new Vector2(0, _Speed_Y);
        _Down_Vector = new Vector2(0, -_Speed_Y);
        _Left_Vector = new Vector2(-_Speed_X, 0);
        _Right_Vector = new Vector2(_Speed_X, 0);
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))  
            _Rdb.velocity = _Up_Vector;
        

        if (Input.GetKey(KeyCode.S))    
            _Rdb.velocity = _Down_Vector;
        

        if (Input.GetKey(KeyCode.A))   
            _Rdb.velocity = _Left_Vector;
        

        if (Input.GetKey(KeyCode.D))  
            _Rdb.velocity = _Right_Vector;
        

        if (!Input.anyKeyDown)  
            _Rdb.velocity = Vector2.zero;
        

    }

}
