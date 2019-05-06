using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private FloatVariable pausedGame;
    public UnityEvent OnPauseMenuActivate;
    public UnityEvent OnPauseMenuDeactivate;

    public void PauseGame(){
        if(pausedGame == 1){
            Resume();
            OnPauseMenuDeactivate?.Invoke();
        }
        else if(pausedGame == 0){
            Pause();
            OnPauseMenuActivate?.Invoke();
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausedGame.SetValue(0);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausedGame.SetValue(1);
    }
}
