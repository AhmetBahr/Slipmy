using slmp.abstracts.Utilities;
using slmp.cont;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.Manager
{
    public class EnemyManager : BahavoirObject<EnemyManager>
    {
        [SerializeField] EnemyCont _enemyPrefab;

        Queue<EnemyCont> _enemies = new Queue<EnemyCont>();

        void Awake()
        {
            SingletonThisObj(this);


        }

        void Start()
        {
            Pool();
        }

        void Pool()
        {
            for(int i = 0; i < 50; i++)
            {
                EnemyCont newEnemy = Instantiate(_enemyPrefab);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = this.transform;
                _enemies.Enqueue(newEnemy);
            }

        }

        public void Setpool(EnemyCont enemyCont)
        {
            enemyCont.gameObject.SetActive(false);
            enemyCont.transform.parent = this.transform;

        }
        public EnemyCont GetPool()
        {
            if(_enemies.Count == 0)
            {
                Pool();
            }
            return _enemies.Dequeue();
        }   

    }

}