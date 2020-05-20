using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorCalls : MonoBehaviour
{

    public Animator sceneFade;

    private int targetLvl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeSceneOut(int levelToLoad)
    {
        sceneFade.SetTrigger("FadeOut");
        targetLvl = levelToLoad;
    }

    private void OnFadeComplete()
    {
        SceneManager.LoadScene(targetLvl);
    }
}
