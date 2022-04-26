using slmp.movvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.cont
{

    public class EnemyCont : MonoBehaviour
    {

        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _maxLife = 25f;


        float _lifeTime = 0f;
        VerticalMover _mover;

        public float MoveSpeed => _moveSpeed;

        void Awake()
        {
            _mover = new VerticalMover(this);
        }

        private void Update()
        {
            _lifeTime += Time.deltaTime;

            if(_lifeTime >= _maxLife)
            {
                killYourself();
            }
        }

        void FixedUpdate()
        {
            _mover.FixedTick();
        }

        public void killYourself()
        {
            Destroy(gameObject);
        }


    }
}