using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum eState {Moving, Diving}
public class eStateEvent:UnityEvent<eState>{}
[CreateAssetMenu(fileName = "StateMachineVariable", menuName = "UnityHelperScripts/StateMachineVariable", order = 0)]
public class StateMachineVariable : ScriptableObject {
    [SerializeField] private eState currentState;
    public eStateEvent OnStateChange;
    public eStateEvent OnStateExit;

    public eState GetCurrentState(){
        return currentState;
    }

    public void SetStateTo(eState newState){
        OnStateExit?.Invoke(currentState);
        currentState = newState;
        OnStateChange?.Invoke(currentState);
    }

    
    public static implicit operator eState(StateMachineVariable reference)
    {
            return reference.currentState;
    }
}