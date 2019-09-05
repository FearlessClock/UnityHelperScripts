using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatVariableSetter : MonoBehaviour
{
    [SerializeField] private FloatVariable variable;
    [SerializeField] private float value;
    private void Awake()
    {
        ResetVariable();
    }

    public void ResetVariable()
    {
        variable.SetValue(value);
    }
}
