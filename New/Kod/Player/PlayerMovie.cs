
using slmp.cont;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace slmp.movvents
{


    public class PlayerMovie
    {
        PlayerCont _playerCont;

        public PlayerMovie(PlayerCont playerCont)
        {
            _playerCont = playerCont;
        }

        public void TinkFixed(float horizontal, float movideSpeed)
        {
            if(horizontal == 0)
            {
                return;
            }

            _playerCont.transform.Translate(Vector3.right * horizontal * Time.deltaTime * movideSpeed);


        }


    }


}
