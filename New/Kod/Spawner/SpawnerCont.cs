using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.cont
{  
    public class SpawnerCont : MonoBehaviour
    {
        [SerializeField] EnemyCont _enemyPrefab;
        [Range(0.1f, 9f)][SerializeField] float _min = 0.1f;
        [Range(10f, 20f)][SerializeField] float _max = 20f;

        float _maxSpawnTime;
        float _currnetSpawnTime = 0f;

        void OnEnable()
        {
            GetRandomTime();
        }

        void Update()
        {
            _currnetSpawnTime += Time.deltaTime;    
            
            if(_currnetSpawnTime > _maxSpawnTime)
            {
                Spawn();
            }
        
        } 

        void Spawn()
        {
            EnemyCont newEnemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;
            _currnetSpawnTime = 0f;
            GetRandomTime();
        }

        public void GetRandomTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }


    }


}