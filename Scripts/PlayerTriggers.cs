using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTriggers : MonoBehaviour
{
    [SerializeField] private TrackSpowner _trackSpowner;
    [SerializeField] private PlayerMove _playerMove;

    private void OnTriggerEnter(Collider other)
    {
        int randomTrack = Random.Range(0, _trackSpowner.Grounds.Count);
        switch (other.tag)
        {
            case "TrackSpowner":
                _trackSpowner.NewPosition += 30;
                Instantiate(_trackSpowner.Grounds[randomTrack], new Vector3(0, 0, _trackSpowner._newPosition), Quaternion.identity);
                break;

            case "CubeWall":
                GameOver();
                break;

            case "TrackGround":
                GameOver();
                break;
        }
    }


    private void GameOver()
    {
        _playerMove.enabled = false;
    }
}
