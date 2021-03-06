using slmp.abstracts.cont;
using slmp.enums;
using slmp.Manager;
using slmp.movvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.cont
{

    public class EnemyCont : ICharacter , IEntityCont
    {
        [SerializeField] EnemyEnums _enemyEnum;

        float _maxLife = 25;
        public float _lifeTime = 0f;
        VerticalMover _mover;

        public EnemyEnums EnemyType => _enemyEnum;
        
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
            EnemyManager.Instance.Setpool(this);
        }


    }
}