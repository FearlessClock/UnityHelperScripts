﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "UnityHelperScripts/GameStateVariable", order = 0)]
public class GameStateVariable : ScriptableObject
{
    public enum GameState { Playing, Pause, GameOver, Victory}
    public GameState value;
    public UnityEvent OnValueChanged;
    public static implicit operator GameState(GameStateVariable reference)
    {
        return reference.value;
    }

    public void SetValue(GameState v)
    {
        this.value = v;
        OnValueChanged?.Invoke();
    }

    public override string ToString()
    {
        return value.ToString();
    }
}
