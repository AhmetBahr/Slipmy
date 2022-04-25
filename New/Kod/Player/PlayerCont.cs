using slmp.abstracts.Input;
using slmp.input;
using slmp.jump;
using slmp.movvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace slmp.cont
{ 
    public class PlayerCont : MonoBehaviour
    {
        [SerializeField] float _movideSpeed = 10f;
        [SerializeField] float _jumpforce = 300f;
        [SerializeField] float _horizantalDiraction = 0f;
        //[SerializeField] bool _isJump;

        PlayerMovie _PlayerMovie;
        JumpRb _jumpRb;
        IInputReader _input;
        float _horizontal;
        bool _isJump;

        private void Awake()
        {
            _PlayerMovie = new PlayerMovie(this);
            _jumpRb = new JumpRb(this);
            _input = new InputReader(GetComponent<PlayerInput>());

        }

        void Update()
        {
            _horizontal = _input.Horizontal;

            if (_input.IsJump)
            {
                _isJump = true;
            }


        }


        public void FixedUpdate()
        {
            _PlayerMovie.TinkFixed(_horizontal, _movideSpeed);

            if (_isJump)
            {
                _jumpRb.TickFixed(_jumpforce);
                
            }
            _isJump = false;


        }

    }

}


