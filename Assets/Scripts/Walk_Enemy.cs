using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_Enemy : MonoBehaviour
{

    float _Speed_X = 5;
    float _Speed_Y = 5;

    Rigidbody2D _Rdb;

    Vector2 _Right_Vector;
    Vector2 _Left_Vector;

    Vector2 _Right_Up_Diagonal;
    Vector2 _Right_Down_Diagonal;

    Vector2 _Left_Up_Diagonal;
    Vector2 _Left_Down_Diagonal;


    void Start()
    {
        _Right_Vector = new Vector2(_Speed_X, _Rdb.velocity.y);
        _Left_Vector = new Vector2(-_Speed_X, _Rdb.velocity.y);

        _Right_Up_Diagonal = new Vector2(_Speed_X, _Speed_Y);
        _Right_Down_Diagonal = new Vector2(_Speed_X, -_Speed_Y);

        _Left_Up_Diagonal = new Vector2(-_Speed_X, _Speed_Y);
        _Left_Down_Diagonal = new Vector2(-_Speed_X, -_Speed_Y);

        _Rdb = GetComponent<Rigidbody2D>();
    }

    public void Right_Movementation()
    {
        _Rdb.velocity = _Right_Vector;
    }

    public void Left_Movementation()
    {
        _Rdb.velocity = _Left_Vector;
    }

    public void Right_Up_Diagonal()
    {
        _Rdb.velocity = _Right_Up_Diagonal;
    }

    public void Right_Down_Diagonal()
    {
        _Rdb.velocity = _Right_Down_Diagonal;
    }

    public void Left_Up_Diagonal()
    {
        _Rdb.velocity = _Left_Up_Diagonal;
    }

    public void Left_Down_Diagonal()
    {
        _Rdb.velocity = _Left_Down_Diagonal;
    }

}
