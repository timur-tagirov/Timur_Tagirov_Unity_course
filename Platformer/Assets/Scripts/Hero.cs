using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour

{
    [SerializeField]

    private float _speed;

    private float _direction;

    public void SetDirection(float direction)
    {
        _direction = direction;
    }


    private void Update()
    {

        if (_direction != 0)
        {
            var delta = _direction * _speed * Time.deltaTime;
            var newXPosition = transform.position.x + delta;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
            

        }

        else if (_direction != 0)

        {
            var delta = _direction * _speed * Time.deltaTime;
            var newYPosition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
       

    }

    public void SaySomething()
    {
        Debug.Log("Something!");
    }
} 
