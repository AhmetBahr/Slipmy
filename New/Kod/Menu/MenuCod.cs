using slmp.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace slmp.UI
{

    public class MenuCod : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene();
        }

        public void ExitButton()
        {

        }
         
    }

}