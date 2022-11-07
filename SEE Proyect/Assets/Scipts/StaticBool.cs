using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBool : MonoBehaviour
{
    public bool Blink = false;
    [SerializeField] public bool pasable = true;
    [SerializeField] private float timer = 0f;

    public void Blinkear()
    {
        if (pasable)
        {
            Blink = true;
            //pasable = false;
        }
    }

    private void Update()
    {
        /*if (!pasable)
        {
            timer += Time.deltaTime;
            if (timer >= 1.5f)
            {
                pasable = true;
                timer = 0f;
            }
        }*/
    }
}
