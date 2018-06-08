using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class click : MonoBehaviour,IVirtualButtonEventHandler {
    public GameObject vb;
    public Animator ani;
    public AudioSource sEff;

    // Use this for initialization
    void Start () {
        vb = GameObject.Find("VirtualButton");
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb.GetComponent<Animator>();
        vb.GetComponent<AudioSource>();
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        ani.Play("RoundKick");
        ani.Play("Frown");
        sEff.Play();
        Debug.Log("BTN pressed");

    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        ani.Play("Run");
        ani.Play("Smile");
        sEff.Stop();
        Debug.Log("BTN realesed");
    }

    // Update is called once per frame
    void Update () {

	}
}
