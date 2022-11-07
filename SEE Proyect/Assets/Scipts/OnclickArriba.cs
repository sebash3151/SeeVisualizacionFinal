using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnclickArriba : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject Cosito;
    [SerializeField] bool adentro = false;
    [SerializeField] float time = 1f;
    private float timer = 0f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        adentro = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //adentro = false;
    }

    private void Update()
    {
        if (adentro)
        {
            Cosito.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= time)
            {
                adentro = false;
                timer = 0f;
            }           
        }
        else
        {
            Cosito.SetActive(false);
            timer = 0f;
        }
    }
}
