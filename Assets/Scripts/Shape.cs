using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string ObjectClassName { get; private set; } = "Shape"; // Encapsulation
    public float speed { get; private set; } = 0.5f; // Encapsulation
    public string shapeName { get; set; }
    private int m_numberOfCorners;
    public int numberOfCorners  // Encapsulation
    {  
        get { return m_numberOfCorners; }
        set
        {
            if (value < 0)
                Debug.LogError("You can't set a negative number of corners!");
            else
                m_numberOfCorners = value;
        }
    }

    private void Update() // will be called in every child with their implementation of Move() function
    {
        Move();
    }

    public virtual void Move()
    { // Abstraction
        Debug.Log("Needs to be overriten");
    }

    public abstract string DisplayName(); // Abstraction
}
