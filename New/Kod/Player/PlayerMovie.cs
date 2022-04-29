
using slmp.abstracts.cont;
using slmp.abstracts.mover;
using slmp.cont;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace slmp.movvents
{


    public class PlayerMovie : IMover
    {
        IEntityCont _playerCont;
        float _movideSpeed;
        float _movideBoundary;


        public PlayerMovie(IEntityCont entityCont)
        {
            _playerCont = entityCont;
            _movideSpeed = entityCont.MoveSpeed;
            _movideBoundary=entityCont.MoveBoundary;


        }

        public void FixedTick(float horizontal)
        {
            if(horizontal == 0)
            {
                return;
            }

            _playerCont.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _movideSpeed);

           

        }


    }


}
