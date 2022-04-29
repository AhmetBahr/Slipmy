using slmp.abstracts.cont;
using slmp.abstracts.Input;
using slmp.abstracts.mover;
using slmp.input;
using slmp.jump;
using slmp.Manager;
using slmp.movvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace slmp.cont
{ 
    public class PlayerCont : ICharacter, IEntityCont
    {

        [SerializeField] float _jumpforce = 300f;
        [SerializeField] float _horizantalDiraction = 0f;
        //[SerializeField] bool _isJump;

        IMover _mover;
        IJump _jumpRb;
        IInputReader _input;
        float _horizontal; 
        bool _isJump;
        bool _isDeat = false;




        private void Awake()
        {
            _mover = new PlayerMovie(this);
            _jumpRb = new JumpRb(this);
            _input = new InputReader(GetComponent<PlayerInput>());

        }

        void Update()
        {
            if (_isDeat)
                return;

            _horizontal = _input.Horizontal;

            if (_input.IsJump)
            {
                _isJump = true;
            }


        }


        public void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jumpRb.FixedTick(_jumpforce); 
                
            }
            _isJump = false;


        }

        void OnTriggerEnter(Collider other)
        {
            IEntityCont entityCont = other.GetComponent<IEntityCont>();
            if (entityCont != null)
            {
                _isDeat = true;
                GameManager.Instance.StopGame();
               
            }
        }


    }

}


