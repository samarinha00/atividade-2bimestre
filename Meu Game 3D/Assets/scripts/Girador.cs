using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girador : MonoBehaviour
{
    private Rigidbody rb;
    public int velocidade = 5;


    private void Start()
    {
        TryGetComponent(out rb);
        
    }
}
