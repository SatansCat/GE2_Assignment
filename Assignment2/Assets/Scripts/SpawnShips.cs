using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public GameObject Sentient;
    public GameObject ShipContainer;
    public GameObject launchLight;
    public AnimatorCalls lvlChangeScript;

    public int LevelToLoad;
    public int NumShips;
    public List<GameObject> Targets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        bool trigger = false;
        yield return new WaitForSeconds(2f);
        for(int i = 0; i < NumShips; i++)
        {
            trigger = !trigger;
            GameObject ship = Instantiate(Sentient, ShipContainer.transform, false);
            ship.GetComponent<Seek>().targetGameObject = Targets[Random.Range(0, Targets.Count)];
            launchLight.SetActive(trigger);
            yield return new WaitForSeconds(.1f);
        }
        yield return new WaitForSeconds(3f);
        lvlChangeScript.FadeSceneOut(LevelToLoad);
        yield return new WaitForSeconds(3f);
    }
}
