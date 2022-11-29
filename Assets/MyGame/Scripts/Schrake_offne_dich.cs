using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schrake_offne_dich : MonoBehaviour
{
    [SerializeField]
    Button s1;
    [SerializeField]
    Button s2;
    [SerializeField]
    Animator ani;

    bool button1;
    bool button2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button1)
        {
            s1.image.color = Color.grey;
        }
        if (!button1)
        {
            s1.image.color = Color.red;
        }
        if (button2)
        {
            s2.image.color = Color.grey;
        }
        if (!button2)
        {
            s2.image.color = Color.red;
        }

        if (button1 && button2)
        {
            ani.SetBool("weiter", true);
        }

    }
    public void einsoffen()
    {
        button1 = !button1;
    }

    public void zweioffen()
    {
        button2 = !button2;
    }
}
