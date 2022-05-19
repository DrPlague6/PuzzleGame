// GENERATED AUTOMATICALLY FROM 'Assets/DefaultInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInput"",
    ""maps"": [
        {
            ""name"": ""Walking"",
            ""id"": ""83957734-c71c-458e-9817-47ef17de1412"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fe849818-d0eb-44e5-ba29-1f63a8cfe5e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""b3f51044-6bd0-4b8d-9cf6-ab32ce777584"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7d8e24f4-42c0-499a-adae-1216849b5fe1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""54fe8fc1-1035-46f3-8912-ce77be4612a8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""df52dbb4-3971-4def-af37-a9d5364a49b8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2af87b6a-0c36-4e0e-aa5f-a9d21958232d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f20e2adc-f35d-42e1-bc9a-deb847d5bfed"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2e36b255-27ed-468e-9f8c-1afe67f68b7f"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5c4379c0-c061-41c6-82f6-0730aaad1ec8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""de9a20de-83cf-441c-aa20-5bccda0e5d3e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walking
        m_Walking = asset.FindActionMap("Walking", throwIfNotFound: true);
        m_Walking_Movement = m_Walking.FindAction("Movement", throwIfNotFound: true);
        m_Walking_Turn = m_Walking.FindAction("Turn", throwIfNotFound: true);
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

    // Walking
    private readonly InputActionMap m_Walking;
    private IWalkingActions m_WalkingActionsCallbackInterface;
    private readonly InputAction m_Walking_Movement;
    private readonly InputAction m_Walking_Turn;
    public struct WalkingActions
    {
        private @DefaultInput m_Wrapper;
        public WalkingActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Walking_Movement;
        public InputAction @Turn => m_Wrapper.m_Walking_Turn;
        public InputActionMap Get() { return m_Wrapper.m_Walking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkingActions set) { return set.Get(); }
        public void SetCallbacks(IWalkingActions instance)
        {
            if (m_Wrapper.m_WalkingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                @Turn.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnTurn;
            }
            m_Wrapper.m_WalkingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
            }
        }
    }
    public WalkingActions @Walking => new WalkingActions(this);
    public interface IWalkingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
}
