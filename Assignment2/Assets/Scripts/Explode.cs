using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public List<GameObject> Ships = new List<GameObject>();
    public GameObject mainExplosion;
    public GameObject ring;
    public GameObject pointLight;

    
 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Sentient")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            mainExplosion.SetActive(true);
            ring.SetActive(true);
            pointLight.SetActive(true);

            foreach(GameObject s in Ships)
            {
                s.GetComponent<Pursue>().enabled = false;
                s.GetComponent<Seek>().enabled = true;


            }
        }
    }
}
