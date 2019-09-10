using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    [SerializeField] private StringVariable loadSceneEffectName = null;
    [SerializeField] private StringVariable newSceneToLoad = null;
    public void AddSceneCallback(StringVariable name)
    {
            Scene scene = SceneManager.GetSceneByName(name);
            if(scene.name != name.value)
            {
                SceneManager.LoadScene(name, LoadSceneMode.Additive);
            }
    }

    public void LoadSceneWithFadeCallback(StringVariable name){
            newSceneToLoad.SetValue(name);
            Scene scene = SceneManager.GetSceneByName(loadSceneEffectName);
            if(scene.name != loadSceneEffectName.value)
            {
                SceneManager.LoadScene(loadSceneEffectName, LoadSceneMode.Additive);
            }
    }
}
