using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void FixedUpdate()
    {
        AutoRun();
        
    }

    private void AutoRun()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
        
    }
}
