using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelFade : MonoBehaviour
{ 
    public AnimatorCalls lvlChangeScript;

    public int LevelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("NextScene");
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(14f);
        lvlChangeScript.FadeSceneOut(LevelToLoad);
    }
}
