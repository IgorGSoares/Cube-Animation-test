using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public ParticleSystem[] ps;
    public GameObject[] alvos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickFogo(){
        StartCoroutine(fogo());
    }

    IEnumerator fogo()
    {
        yield return new WaitForSeconds(0.5f);
        ps[0].Play();
    }

    public void clickExpelir(){
        StartCoroutine(expelir());
    }

    IEnumerator expelir()
    {
        yield return new WaitForSeconds(0.5f);
        ps[1].Play();
    }

    public void clickSpell(){
        StartCoroutine(spell());
    }

    IEnumerator spell()
    {
        yield return new WaitForSeconds(1.25f);
        ps[2].Play();
        //yield return new WaitForSeconds(1);
        alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
        ps[3].Play();
        yield return new WaitForSeconds(5);
        alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
    }

    public void clickP3(){
        StartCoroutine(P3());
    }

    IEnumerator P3()
    {
        yield return new WaitForSeconds(0.9f);
        ps[4].Play();
        yield return new WaitForSeconds(0.7f);
        ps[4].Play();
        yield return new WaitForSeconds(0.5f);
        ps[4].Play();
    }

    public void clickP(){
        StartCoroutine(P());
    }

    IEnumerator P()
    {
        yield return new WaitForSeconds(0.2f);
        ps[4].Play();
    }

    public void clickE(){
        StartCoroutine(E());
    }

    IEnumerator E()
    {
        yield return new WaitForSeconds(0.5f);
        ps[6].Play();
        alvos[1].GetComponent<Renderer>().enabled = !alvos[1].GetComponent<Renderer>().enabled;
        
        yield return new WaitForSeconds(1.5f);
        alvos[1].GetComponent<Renderer>().enabled = !alvos[1].GetComponent<Renderer>().enabled;
    }

    public void clickD(){
        //StartCoroutine(D());
        ps[5].Play();
    }

    IEnumerator D()
    {
        yield return new WaitForSeconds(0.1f);
        ps[5].Play();
    }
    // public void playPS(){
    //     ps.Play();
    // }

    // public void clickado(){
    //     StartCoroutine(test());
    // }

    // IEnumerator test()
    // {
    //     yield return new WaitForSeconds(2);
    //     playPS();
    //     alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
    //     yield return new WaitForSeconds(2);
    //     alvos[0].GetComponent<Renderer>().enabled = !alvos[0].GetComponent<Renderer>().enabled;
    // }
}
