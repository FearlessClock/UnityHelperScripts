using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AfterTimeEvent : MonoBehaviour
{
    [SerializeField] private float time;
    public UnityEvent OnTimerDone;

    private void Awake()
    {
        Invoke("LauchEvent", time);
    }

    private void LauchEvent()
    {
        OnTimerDone?.Invoke();
    }
}
