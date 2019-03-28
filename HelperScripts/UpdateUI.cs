using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] private string prefix;

    [SerializeField] private FloatVariable valueVar;
    [SerializeField] private string suffix;
    private TextMeshProUGUI textToUpdate;

    private void OnEnable() {
        textToUpdate = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(float value){
        if(textToUpdate){
            textToUpdate.SetText(prefix + value.ToString() + suffix);
        }
    }

    public void Update(){
        if(valueVar != null){
            UpdateText(valueVar);
        }
    }
}
