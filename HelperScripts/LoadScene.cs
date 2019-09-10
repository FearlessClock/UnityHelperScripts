using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{    
    public void LoadSceneCallback(StringVariable name){
        StartCoroutine("LoadSceneWithFade", name);
    }

    private IEnumerator LoadSceneWithFade(StringVariable name){
        SceneManager.LoadScene(name, LoadSceneMode.Single );
        yield return null;
    }
}
