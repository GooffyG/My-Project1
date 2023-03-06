using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class CubeTransform : TransformFigures
{
    TransformFigures transformFigures;

    //Abstraction
    void Start()
    {
        transformFigures = GetComponent<TransformFigures>();
        InvokeRepeating("ChangeColor", delayTimeColor, transformFigures.repeatTimeColor);
        InvokeRepeating("ChangeScale", delayChangeScale, repeatChangeScale);
    }

    //Inheritance
    public override void Update()
    {
        base.Update();
    }
    //Inheritance
    public override void ChangeColor()
    {
        base.ChangeColor();
    }
    //Polymorphism
    public override void ChangeScale()
    {
        base.ChangeScale();
        if(Input.GetKey(KeyCode.Space))
        {
            float scaleX = 2f;
            float scaleY = 8f;
            transform.localScale = Vector3.one * Random.Range(scaleX, scaleY);
        }
    }
}
