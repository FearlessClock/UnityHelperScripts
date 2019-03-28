using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Animator))]
public class LoadScene : MonoBehaviour
{
    private Animator animator;
    [Header("'Load' trigger to start selected animation")]
    [SerializeField] private AnimationClip fadeClip;
    
    private float fadeTime;
    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        
        if(Input.GetKeyUp(KeyCode.Escape)){
            StartCoroutine("QuitGameWithFade");
        }
    }

    public void LoadSceneCallback(StringVariable name){
        StartCoroutine("LoadSceneWithFade", name);
    }

    private IEnumerator LoadSceneWithFade(StringVariable name){
        animator.SetTrigger("Load");
        yield return new WaitForSeconds(fadeClip.length);
        SceneManager.LoadSceneAsync(name, LoadSceneMode.Single );
    }

    private IEnumerator QuitGameWithFade(){
        animator.SetTrigger("Load");
        yield return new WaitForSeconds(fadeClip.length);
        Application.Quit();
    }
}
