using UnityEngine;

[CreateAssetMenu(fileName = "ButtonVariable", menuName = "PlanetSlinger/ButtonVariable", order = 0)]
public class ButtonVariable : ScriptableObject {
    [SerializeField] private KeyCode buttonKeyboardName;
    [SerializeField] private KeyCode buttonJoystickName;
    [SerializeField] private string buttonDescription;

    public KeyCode GetButton(bool joystick = true){
        return joystick? buttonJoystickName:buttonKeyboardName;
    }
}