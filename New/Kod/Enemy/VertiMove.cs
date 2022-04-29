using slmp.abstracts.cont;
using slmp.abstracts.mover;
using slmp.cont;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.movvents
{
    public class VerticalMover : IMover
    {
        IEntityCont _entityCont;
        float _moveSpeed;



        public VerticalMover(IEntityCont entityCont)
        {
            _entityCont = entityCont;
            _moveSpeed = _entityCont.MoveSpeed;
        }

        public void FixedTick(float vertical = -1)
        {
            _entityCont.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }

    }

}