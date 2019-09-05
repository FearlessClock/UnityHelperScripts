using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    public void AddSceneCallback(StringVariable name)
    {
        Scene scene = SceneManager.GetSceneByName(name);
        if(scene.name != name.value)
        {
            SceneManager.LoadScene(name, LoadSceneMode.Additive);
        }
    }
}
