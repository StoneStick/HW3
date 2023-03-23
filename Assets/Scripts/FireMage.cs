using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMage : MonoBehaviour
{
    [SerializeField] private ParticleSystem fireBall;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("IsConjures", true);
            fireBall.Play();
            _animator.SetBool("IsConjures", false);
        }
    }
}
