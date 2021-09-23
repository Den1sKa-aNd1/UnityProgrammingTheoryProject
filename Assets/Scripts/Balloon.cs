using UnityEngine;

public class Balloon: Shape // Inheritance
{
    public override string DisplayName() // Polymorphism
    {
        Debug.Log("Baloon shape name: " + shapeName);
        Debug.Log("Baloon class Object name: " + ObjectClassName); // Take from parent cannot set from child

        return shapeName;
    }
    public override void Move() // Polymorphism
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void Awake()
    {
        Initialize(); // Abstraction
    }

    private void Initialize()
    {
        shapeName = gameObject.name;
        numberOfCorners = 99;
        DisplayName();
    }
}
