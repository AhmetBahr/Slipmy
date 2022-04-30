using slmp.abstracts.Utilities;
using slmp.cont;
using slmp.enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.Manager
{
    public class EnemyManager : BahavoirObject<EnemyManager>
    {
        [SerializeField] EnemyCont[] _enemyPrefabs;

        Dictionary<EnemyEnums,Queue<EnemyCont>> _enemies = new Dictionary<EnemyEnums, Queue<EnemyCont>>();

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
            for (int i = 0; i < _enemyPrefabs.Length; i++)
            {
                Queue<EnemyCont> enemyConts = new Queue<EnemyCont>();

                for (int k = 0; k < 50; k++)
                {
                    EnemyCont newEnemy = Instantiate(_enemyPrefabs[Random.Range(0, _enemyPrefabs.Length)]);
                    newEnemy.gameObject.SetActive(false);
                    newEnemy.transform.parent = this.transform;
                    enemyConts.Enqueue(newEnemy);

                }
                _enemies.Add((EnemyEnums)i,enemyConts);
            }

        }

        public void Setpool(EnemyCont enemyCont)
        {
            enemyCont.gameObject.SetActive(false);
            enemyCont.transform.parent = this.transform;

            Queue<EnemyCont> enemyConts = _enemies[enemyCont.EnemyType];
            enemyConts.Enqueue(enemyCont);
        }
        public EnemyCont GetPool(EnemyEnums enemyType)
        {
            Queue<EnemyCont> enemyConts = _enemies[enemyType];

            if(enemyConts.Count == 0)
            {
                for(int i=0; i< 2; i++)
                {

                    EnemyCont newEnemy = Instantiate(_enemyPrefabs[(int)enemyType]);
                    enemyConts.Enqueue(newEnemy);

                }

            }


            return enemyConts.Dequeue();
        }   

    }

}