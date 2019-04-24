using UnityEngine;

[CreateAssetMenu(fileName = "StringVariable", menuName = "UnityHelperScripts/StringVariable", order = 0)]
public class StringVariable : ScriptableObject {
    public string value;

    public static implicit operator string(StringVariable reference)
    {
            return reference.value;
    }
}