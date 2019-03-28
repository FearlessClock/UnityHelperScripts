using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivation : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private void OnEnable() {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void ActivateCanvas(bool isActive){
        canvasGroup.interactable = isActive;
        canvasGroup.blocksRaycasts = isActive;
        canvasGroup.alpha = isActive? 1 : 0;
    }
}
