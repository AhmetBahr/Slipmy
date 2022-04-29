using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.abstracts.mover
{
    public interface IMover 
    {
        void FixedTick(float direction);
    }

}