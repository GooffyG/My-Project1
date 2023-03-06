using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class SphereTransform : TransformFigures
{
    TransformFigures transformFigures;

    //Abstraction
    void Start()
    {
        transformFigures = GetComponent<TransformFigures>();
        InvokeRepeating("ChangeColor", delayTimeColor/2, transformFigures.repeatTimeColor/2);
        InvokeRepeating("ChangeScale", delayChangeScale/2, repeatChangeScale/2);
    }
    //Polymorphism
    public override void ChangeColor()
    {
        base.ChangeColor();
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0.5f, 0.0f, 0.1f, 0.0f, 0.2f, 0.1f, 0.2f, 0.4f);
        }
    }
    //Polymorphism
    public override void ChangeScale()
    {
        base.ChangeScale();
        if (Input.GetKey(KeyCode.Space))
        {
            float scaleX = 1f;
            float scaleY = 6f;
            transform.localScale = Vector3.one * Random.Range(scaleX, scaleY);
        }
    }
}
