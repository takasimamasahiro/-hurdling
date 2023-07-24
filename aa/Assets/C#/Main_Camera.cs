using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Camera : MonoBehaviour
{
    GameObject playerObj;
    PlayerMove player;
    Transform playerTransform;
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<PlayerMove>();
        playerTransform = playerObj.transform;
    }
    void LateUpdate()
    {
        MoveCamera();
    }
    void MoveCamera()
    {
        //�����������Ǐ]
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }
}