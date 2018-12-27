 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start () {
		//offset is the distance between camera and the player
        offset = transform.position - player.transform.position;
    }
    void LateUpdate () {
		//changing the position of camera according to the offset
        transform.position = player.transform.position + offset;
    }
}
