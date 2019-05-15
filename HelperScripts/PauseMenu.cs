using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameStateVariable stateVariable;
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
        Time.timeScale = 1;
        stateVariable.SetValue(GameStateVariable.GameState.Playing);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        stateVariable.SetValue(GameStateVariable.GameState.Pause);
    }
}
