using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TransformFigures : MonoBehaviour
{
    public MeshRenderer Renderer;
    //Encapsulation
    public float delayTimeColor { get => 1.0f; }
    public float repeatTimeColor { get => 0.7f; }
    public float delayChangeScale { get => 1.0f; }
    public float repeatChangeScale { get => 0.5f; }
    

    public virtual void Update()
    {
        ChangeRotate();
    }

    public virtual void ChangeColor()
    {
       GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1.0f, 0f, 1.0f, 0f, 1.0f, 0f, 1.0f);
    }

    public virtual void ChangeRotate()
    {

        float speedRotateX = Random.Range(1.0f, 10.0f);
        float speedRotateY = Random.Range(4.0f, 5.0f);
        float speedRotateZ = Random.Range(6.0f, 7.0f);
        float posRotation = Random.Range(0.0f, 10.0f);

        transform.Rotate(posRotation * speedRotateX * Time.deltaTime
                , posRotation * speedRotateY * Time.deltaTime,
                posRotation * speedRotateZ * Time.deltaTime);
    }


    public virtual void ChangeScale()
    {
        float scaleX = 1f;
        float scaleY = 2f;


        transform.localScale = Vector3.one * Random.Range(scaleX, scaleY);
    }
}

