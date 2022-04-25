using slmp.abstracts.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace slmp.input
{

    public class InputReader : IInputReader
    {
        PlayerInput _playerInput;

        public float Horizontal
        {
            get;
            private set;
        }

        public bool IsJump
        {
            get;
            private set;    
        }

       public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;

            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            _playerInput.currentActionMap.actions[1].started += OnJump;
            _playerInput.currentActionMap.actions[1].canceled += OnJump;

        }

        void OnHorizontalMove(InputAction.CallbackContext obj)
        {
            Horizontal = obj.ReadValue<float>();
        }
        void OnJump(InputAction.CallbackContext obj)
        {
            IsJump = obj.ReadValueAsButton();
        }





    }

}