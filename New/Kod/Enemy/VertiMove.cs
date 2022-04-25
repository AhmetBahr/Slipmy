using slmp.cont;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.movvents
{
    public class VerticalMover 
    {
        EnemyCont _enemycont;
        float _moveSpeed;



        public VerticalMover(EnemyCont enemycont)
        {
            _enemycont = enemycont;
            _moveSpeed = _enemycont.MoveSpeed;
        }

        public void FixedTick(float vertical = -1)
        {
            _enemycont.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }

    }

}