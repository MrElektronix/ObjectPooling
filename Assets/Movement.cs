using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float _speed;

    private void Start()
    {
        _speed = 10f;
    }

    private void Update()
    {
     transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }

}
