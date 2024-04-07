using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSpowner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tracks;

    private int _newPosition = 90;

    public List<GameObject> Grounds
    {
        get => _tracks;
        set => _tracks = value;
    }
}
