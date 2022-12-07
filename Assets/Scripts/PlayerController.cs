using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 20.0f;
    [SerializeField] private float _turn = 40.0f;

    private float ForwardMove;
    private float TurnMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTank();
    }

    private void MoveTank()
    {
        ForwardMove = Input.GetAxis("Vertical");
        TurnMove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * _speed * ForwardMove * Time.deltaTime);
        transform.Rotate(Vector3.up,_turn * TurnMove * Time.deltaTime);
    }
}
