using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] private GameObject _gameObject;

    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
           ObjectPool.instance.GetObjectForType("Enemy", true);
       }

        if (Input.GetKeyDown(KeyCode.R))
        {

        }
    }
}
