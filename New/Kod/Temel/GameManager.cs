using slmp.abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.Manager
{

    public class GameManager : BahavoirObject<GameManager>
    {

        void Awake()
        {
            SingletonThisObj(this);

        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }

        public void LoadScene()
        {
            Debug.Log("Baþladý"); 
        }


    }
}
