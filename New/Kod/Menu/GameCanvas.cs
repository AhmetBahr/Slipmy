using slmp.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.UI
{
    public class GameCanvas : MonoBehaviour
    {

        [SerializeField] DeathMenu _gameOverPanel;


        void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
        }

        void OnEnable()
        {
           GameManager.Instance.OnGameStop += HandleOnGameStop;
        }
        void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;

        }

        private void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }

    }



}
