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

    public void LoadSceneCallback(StringVariable name){
        StartCoroutine("LoadSceneWithFade", name);
    }

    private IEnumerator LoadSceneWithFade(StringVariable name){
        animator.SetTrigger("Load");
        if(fadeClip != null)
        {
            yield return new WaitForSeconds(fadeClip.length);
        }
        SceneManager.LoadScene(name, LoadSceneMode.Single );
    }
}
