using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.abstracts.Utilities
{

    public abstract class BahavoirObject<T> : MonoBehaviour where T : Component
    {

        public static T Instance { get; private set; }

        protected void SingletonThisObj(T entity)
        {
            if( Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }



    }

}