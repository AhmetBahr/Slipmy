using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.abstracts.Input
{

    public interface IInputReader
    {
        float Horizontal { get; }
        bool IsJump { get; }




    }

}
