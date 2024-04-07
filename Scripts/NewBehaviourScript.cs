using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private int pole = 0;
    [SerializeField] private GameObject gameObject;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gameObject, new Vector3(pole, 0, 0), Quaternion.identity);
            pole += 1;
        }
    }
}
