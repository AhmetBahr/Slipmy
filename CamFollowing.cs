using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowing : MonoBehaviour
{
    //                              1. Y�ntem
    
        public Transform targer;
        public Vector3 offSet;
        private float smoothspeed = 0.125f;

        private void LateUpdate()
        {

            Vector3 desiredPositon = targer.position + offSet;
           // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothspeed);
            transform.position = desiredPositon ;

            transform.LookAt(targer);   
        }
        

                                //Ikinci Y�ntem
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
