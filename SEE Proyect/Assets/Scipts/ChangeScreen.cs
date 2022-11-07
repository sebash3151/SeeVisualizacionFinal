using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    private bool here = false;
    public static GameObject currentPage;
    [SerializeField] GameObject nextPage;
    Animator anim;
    [SerializeField] AudioSource audio;
    private StaticBool blink;

    private void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("anim").GetComponent<Animator>();
        blink = GameObject.FindGameObjectWithTag("anim").GetComponent<StaticBool>();
        currentPage = GameObject.FindGameObjectWithTag("pag");
        audio = GameObject.FindGameObjectWithTag("sound").GetComponent<AudioSource>();
        Debug.Log(currentPage);
    }

    public void Pasar()
    {
        anim.SetTrigger("pass");
        here = true;
        audio.Play();
        /*if (blink.pasable)
        {
            
        }*/
    }

    private void Update()
    {
        if (here && blink.Blink)
        {
            currentPage.SetActive(false);
            nextPage.SetActive(true);
            currentPage = nextPage;
            here = false;
            blink.Blink = false;
            Debug.Log(currentPage);
        }
    }
}
