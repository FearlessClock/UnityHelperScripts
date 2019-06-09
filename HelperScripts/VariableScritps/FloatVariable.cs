using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "UnityHelperScripts/FloatVariable", order = 0)]
public class FloatVariable : ScriptableObject 
{
    public float value;
    public FloatEvent OnValueChanged;
    public static implicit operator float(FloatVariable reference)
    {
            return reference.value;
    }

    public void SetValue(float v)
    {
        this.value = v;
        OnValueChanged?.Invoke(v);
    }

    public void Add(float v)
    {
        this.value += v;
        OnValueChanged?.Invoke(this.value);
    }

    public override string ToString(){
        return value.ToString();
    }
}