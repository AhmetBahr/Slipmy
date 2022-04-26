using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCont : MonoBehaviour
{
    //                              1. Yöntem

    public Transform targer;
    public Vector3 offSet;
    private float smoothspeed = 0.150f;

    private void LateUpdate()
    {

        Vector3 desiredPositon = targer.position + offSet;
         Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothspeed);
        transform.position = smoothedPosition;

        transform.LookAt(targer);
    }


    //Ikinci Yöntem
    /*
    private Transform lookAt;
    public Vector3 offSet;
    private void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - lookAt.position;
    }
    private void Update()
    {
        transform.position = lookAt.position + offSet;
    }
    */

}