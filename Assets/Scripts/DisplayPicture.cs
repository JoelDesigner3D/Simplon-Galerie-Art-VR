using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPicture : MonoBehaviour
{

    bool state;

    private void Start()
    {
        state = false;
        this.gameObject.SetActive(state);
    }

    public void Display()
    {
        state = !state;
        this.gameObject.SetActive(state);
    }
}
