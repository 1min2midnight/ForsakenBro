using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAttack : MonoBehaviour
{
    public Color spriteColor = Color.white;
    
    SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.material.color = spriteColor;


    }

    


}
