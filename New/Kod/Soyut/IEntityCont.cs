using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.abstracts.cont
{
    public interface IEntityCont  
    {
        Transform transform { get; }

        float MoveSpeed { get; }
        float MoveBoundary { get; }

    }

}