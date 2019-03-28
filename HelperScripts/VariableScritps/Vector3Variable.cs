using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Vector3Variable", menuName = "Jelly fish jumper/Vector3Variable", order = 0)]
public class Vector3Variable : ScriptableObject {
    public Vector3 value;

    public static implicit operator Vector3(Vector3Variable reference)
    {
            return reference.value;
    }

    internal void SetValue(Vector3 position)
    {
        value = position;
    }
}