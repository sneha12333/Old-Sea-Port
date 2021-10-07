using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonTrigger : MonoBehaviour
{
    public static event Action onButtonPressed;

    private Animator _buttonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        _buttonAnimator = GetComponent<Animator>();  
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag =="Player");
        {
            _buttonAnimator.SetTrigger("ButtonPress");
            onButtonPressed?.Invoke();
        }
    }
}
