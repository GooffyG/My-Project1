using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class CylinderTransform : TransformFigures
{
    TransformFigures transformFigures;
    private float delayChangeRotation = 1f;
    private float repeatChangeRotation = 1f;
    //Abstraction
    void Start()
    {
        transformFigures = GetComponent<TransformFigures>();
        InvokeRepeating("ChangeColor", delayTimeColor, transformFigures.repeatTimeColor);
        InvokeRepeating("ChangeScale", delayChangeScale, repeatChangeScale);
        InvokeRepeating("ChangeRotation", delayChangeRotation, repeatChangeRotation);
    }
    //Abstraction    
    public override void ChangeColor()
    {
        base.ChangeColor();
    }
    //Polymorphism
    public override void ChangeScale()
    {
        base.ChangeScale();
        if (Input.GetKey(KeyCode.Space))
        {
            float scaleX = 4f;
            float scaleY = 5f;
            transform.localScale = Vector3.one * Random.Range(scaleX, scaleY);
        }
    }
    //Polymorphism
    public override void ChangeRotate()
    {
        base.ChangeRotate();
        if (Input.GetKey(KeyCode.Space))
        {
            float speedRotateX = Random.Range(8.0f, 20.0f);
            float speedRotateY = Random.Range(8.0f, 20.0f);
            float speedRotateZ = Random.Range(8.0f, 20.0f);
            float posRotation = Random.Range(0.0f, 0.0f);

            transform.Rotate(posRotation * speedRotateX * Time.deltaTime
                    , posRotation * speedRotateY,
                    posRotation * speedRotateZ * Time.deltaTime);
        }
    }
}
