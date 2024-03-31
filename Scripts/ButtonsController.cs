using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;

    private void Start()
    {
        _playerMove.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;
    }
}
