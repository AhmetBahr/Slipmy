using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace slmp.UI
{
    public class ScoreCont : MonoBehaviour
    {
        TMP_Text _Text;
        float _Time;

        private void Awake()
        {
            _Text = GetComponent<TMP_Text>();
            
        }

        private void Update()
        {
            _Time += Time.deltaTime;
            _Text.text = _Time.ToString("0"); 
        }

    }

}