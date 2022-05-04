using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
public class ButtonListener : MonoBehaviour
{
    public UnityEvent proximityEvent;
    public UnityEvent contactEvent;
    public UnityEvent actionEvent;
    public UnityEvent defaultEvent;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
    }

    void InitiateEvent(InteractableStateArgs state)
    {
        if (state.NewInteractableState == InteractableState.ProximityState)
            proximityEvent.Invoke();
        if (state.NewInteractableState == InteractableState.ContactState)
            contactEvent.Invoke();
        if (state.NewInteractableState == InteractableState.ActionState)
            actionEvent.Invoke();
        else
            defaultEvent.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
