using UnityEngine;

public class ColorDecorator : MonoBehaviour
{
    public Renderer objRenderer;

    private Vector3 lastDirection;

    void Start()
    {
        if (objRenderer == null)
            objRenderer = GetComponent<Renderer>();

        lastDirection = transform.forward;
    }

    void Update()
    {
        Vector3 currentDirection = transform.forward;

        if (currentDirection != lastDirection)
        {
            ChangeColor();
            lastDirection = currentDirection;
        }
    }

    void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        objRenderer.material.color = randomColor;
    }
}