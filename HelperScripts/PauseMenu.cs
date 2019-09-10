using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameStateVariable stateVariable = null;
    [SerializeField] private bool stopTime = true;
    public UnityEvent OnPauseMenuActivate;
    public UnityEvent OnPauseMenuDeactivate;

    public void PauseGame(){
        if (stateVariable == GameStateVariable.GameState.Pause)
        {
            Resume();
            OnPauseMenuDeactivate?.Invoke();
        }
        else if (stateVariable == GameStateVariable.GameState.Playing)
        {
            Pause();
            OnPauseMenuActivate?.Invoke();
        }
    }

    public void Resume()
    {
        if (stopTime)
        {
            Time.timeScale = 1;
        }
        stateVariable.SetValue(GameStateVariable.GameState.Playing);
    }

    public void Pause()
    {
        if (stopTime)
        {
            Time.timeScale = 0;
        }
        stateVariable.SetValue(GameStateVariable.GameState.Pause);
    }
}
