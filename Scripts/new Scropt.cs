using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScropt : MonoBehaviour
{
    public float pole = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pole * 2 * Time.deltaTime, 0, 0);
        pole = pole - 1;
    }
}
