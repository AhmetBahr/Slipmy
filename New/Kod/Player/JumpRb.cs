using slmp.abstracts.mover;
using slmp.cont;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.jump
{
   public class JumpRb : IJump
    {


        private Rigidbody _rigitbody;

        public JumpRb(PlayerCont playerCont)
        {
            _rigitbody = playerCont.GetComponent<Rigidbody>();
        }

        public void FixedTick(float Jumpforce)
        {
            if(_rigitbody.velocity.y != 0)
            {
                return;
            }

            _rigitbody.velocity = Vector3.zero;
            _rigitbody.AddForce(Vector3.up * Time.deltaTime * Jumpforce);


        }






    }
}