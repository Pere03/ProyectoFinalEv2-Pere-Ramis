using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 30, 1);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
