using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Jelly fish jumper/FloatVariable", order = 0)]
public class FloatVariable : ScriptableObject 
{
    public float value;

    public static implicit operator float(FloatVariable reference)
    {
            return reference.value;
    }

    public void SetValue(float v)
    {
        this.value = v;
    }

    public override string ToString(){
        return value.ToString();
    }
}