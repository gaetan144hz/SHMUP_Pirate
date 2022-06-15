// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""c7bde20b-7ab5-4a2d-b4dd-c3650775aa6c"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""307fd96f-1dc5-41d1-bf97-36fddfde3758"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""67858bbd-6177-4f13-b5bd-7030079468b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""spell"",
                    ""type"": ""Button"",
                    ""id"": ""34ae475e-29cf-44cc-883e-19c6c56c1a51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""201f246d-4e53-42dc-8a5d-04f975326791"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""resume"",
                    ""type"": ""Button"",
                    ""id"": ""7cea66bf-966a-4bdc-ba28-4451c06f3c0c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""12054f81-feef-4623-b7bb-384cc5ab053e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8a14c030-78f4-4ced-b5c5-783e949b3ca7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ce51c180-2b33-4372-a9b1-916f3da6ec7f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""30ab0d3c-2448-43b3-9c11-468d4fbd6a71"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c8476bd-5ba0-4514-a9f9-9c66b8ba4d4a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6123f503-e366-4757-adc9-a80f488dade3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a3db429-ecba-4410-886f-0e969017eb86"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02de8e0d-04d5-49e7-a134-0aedf68ab2d5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""spell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc753bff-00db-4853-abee-3c6d53405644"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7290f287-fc89-49f7-9971-4ddce40652cb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_shoot = m_player.FindAction("shoot", throwIfNotFound: true);
        m_player_spell = m_player.FindAction("spell", throwIfNotFound: true);
        m_player_pause = m_player.FindAction("pause", throwIfNotFound: true);
        m_player_resume = m_player.FindAction("resume", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_shoot;
    private readonly InputAction m_player_spell;
    private readonly InputAction m_player_pause;
    private readonly InputAction m_player_resume;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @spell => m_Wrapper.m_player_spell;
        public InputAction @pause => m_Wrapper.m_player_pause;
        public InputAction @resume => m_Wrapper.m_player_resume;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @spell.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell;
                @spell.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell;
                @spell.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell;
                @pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @resume.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @resume.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @resume.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @spell.started += instance.OnSpell;
                @spell.performed += instance.OnSpell;
                @spell.canceled += instance.OnSpell;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @resume.started += instance.OnResume;
                @resume.performed += instance.OnResume;
                @resume.canceled += instance.OnResume;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSpell(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
    }
}
