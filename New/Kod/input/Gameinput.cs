//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Kod/input/Gameinput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace slmp.input
{
    public partial class @Gameinput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Gameinput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Gameinput"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""f8688be4-b054-4bb3-baf8-f7b37758e3ac"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f7ef72fc-f42d-4b28-aa3f-3200f7b5a416"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""88644b5c-4851-417e-8728-0229a517e286"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""44a1e943-de04-49bf-9807-8de8af5de1f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""60410f97-9359-478c-84b9-ba149763b76f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""00d7a43f-351b-44c1-80e1-72107f8fa0a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a1f72de-2489-4db4-b281-ee1bb272724c"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOnFoot
            m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
            m_PlayerOnFoot_HorizontalMove = m_PlayerOnFoot.FindAction("HorizontalMove", throwIfNotFound: true);
            m_PlayerOnFoot_Jump = m_PlayerOnFoot.FindAction("Jump", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // PlayerOnFoot
        private readonly InputActionMap m_PlayerOnFoot;
        private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
        private readonly InputAction m_PlayerOnFoot_HorizontalMove;
        private readonly InputAction m_PlayerOnFoot_Jump;
        public struct PlayerOnFootActions
        {
            private @Gameinput m_Wrapper;
            public PlayerOnFootActions(@Gameinput wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorizontalMove => m_Wrapper.m_PlayerOnFoot_HorizontalMove;
            public InputAction @Jump => m_Wrapper.m_PlayerOnFoot_Jump;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnFootActions instance)
            {
                if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
                {
                    @HorizontalMove.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @Jump.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorizontalMove.started += instance.OnHorizontalMove;
                    @HorizontalMove.performed += instance.OnHorizontalMove;
                    @HorizontalMove.canceled += instance.OnHorizontalMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
        public interface IPlayerOnFootActions
        {
            void OnHorizontalMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}