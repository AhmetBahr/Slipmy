using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace slmp.abstracts.cont
{

    public abstract class ICharacter : MonoBehaviour
    {
        [SerializeField] float _moveBoundary = 5f;

        [SerializeField] float _moveSpeed = 10f;

        public float MoveSpeed => _moveSpeed;

        public float MoveBoundary => _moveBoundary;

}

}