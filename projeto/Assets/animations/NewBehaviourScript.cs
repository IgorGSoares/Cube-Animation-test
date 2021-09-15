using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ps;
    public GameObject[] alvos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playPS(){
        ps.Play();
    }

    public void clickado(){
        StartCoroutine(test());
    }

    IEnumerator test()
    {
        yield return new WaitForSeconds(2);
        playPS();
        alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
        yield return new WaitForSeconds(2);
        alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
    }
}
