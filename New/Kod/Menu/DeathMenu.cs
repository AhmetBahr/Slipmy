using slmp.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.UI
{

    public class DeathMenu : MonoBehaviour
    {
      
        public void ResartBT()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void MenuBT()
        {
            GameManager.Instance.LoadScene("Menu");
        }


    }

}