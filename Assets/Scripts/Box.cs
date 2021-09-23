using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box: Shape
{
    public override string DisplayName() // Polymorphism
    {
        Debug.Log("Box shape name: "+ shapeName);
        Debug.Log("Box class Object name: " + ObjectClassName); // Take from parent cannot set from child

        return shapeName;
    }

    public override void Move() // Polymorphism
    {
        transform.Translate(Vector3.up * -1 * speed * Time.deltaTime);
    }

    private void Awake()
    {
        Initialize(); // Abstraction
    }

    private void Initialize()
    {
        shapeName = gameObject.name;
        numberOfCorners = 8;
        DisplayName();
    }
}
