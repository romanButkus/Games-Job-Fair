using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public float _speed = 10f;
    [SerializeField] private Animator animator;

    

    private void FixedUpdate()
    {
        AutoRun();
    }

    private void AutoRun()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
        
    }
}
