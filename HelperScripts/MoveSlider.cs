using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSlider : MonoBehaviour
{
    [SerializeField] private Slider slider;

    [SerializeField] private FloatVariable amount;
    private void Update() {
        slider.value = amount;
    }
}
