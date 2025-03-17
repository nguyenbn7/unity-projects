using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    GameObject thingToFollow;

    private readonly Vector3 distance = new Vector3(0, 0, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + distance;
    }
}
