using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    private bool here = false;
    private GameObject currentPage;
    [SerializeField] GameObject nextPage;
    Animator anim;
    private StaticBool blink;

    private void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("anim").GetComponent<Animator>();
        blink = GameObject.FindGameObjectWithTag("anim").GetComponent<StaticBool>();
        currentPage = GameObject.FindGameObjectWithTag("pag");
        Debug.Log(currentPage);
    }

    public void Pasar()
    {
        if (blink.pasable)
        {
            anim.SetTrigger("pass");
            here = true;
        }
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
