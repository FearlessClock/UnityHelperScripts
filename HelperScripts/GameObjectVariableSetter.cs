using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectVariableSetter : MonoBehaviour
{
    [SerializeField] private GameObjectVariable gameobjectVariable;

    private void Awake()
    {
        gameobjectVariable.SetValue(this.gameObject);
    }
}
