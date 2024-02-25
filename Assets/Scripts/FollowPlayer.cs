using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 7, -6.42f);
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
