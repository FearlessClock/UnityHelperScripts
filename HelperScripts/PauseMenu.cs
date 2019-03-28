using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool pausedGame;
    [SerializeField] private CanvasActivation pauseMenuCanvasActivation;

    public void PauseGame(){
        Debug.Log("Pause game");
        if(pausedGame){
            Time.timeScale = 1;
            pausedGame = false;
            pauseMenuCanvasActivation.ActivateCanvas(false);
        }
        else{
            Time.timeScale = 0;
            pausedGame = true;
            pauseMenuCanvasActivation.ActivateCanvas(true);
        }
    }
}
