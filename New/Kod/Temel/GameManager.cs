using slmp.abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace slmp.Manager
{

    public class GameManager : BahavoirObject<GameManager>
    {
        public event System.Action stop;

        void Awake()
        {
            SingletonThisObj(this);

        }

        public void StopGame()
        {
            Time.timeScale = 0f;

            if(stop != null)
            {
                stop();
            }

        }




        public void LoadScene(string sceneName)
        {
            Debug.Log("Baþladý");
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

    }
}
