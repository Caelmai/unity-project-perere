using UnityEngine;
using System.Collections;

public static class TransformExtensions
{
    /// <summary>
    /// Enforces the bounds.
    /// </summary>
    public static void EnforceBounds(this Transform transform, Camera mainCamera, Renderer renderer)
    {
        // Current positions.
        Vector3 currentPosition = transform.position;
        Vector2 currentCameraPosition = mainCamera.transform.position;
        Vector2 boundSize = renderer.bounds.size / 2;

        // Get X distances.
        float xDistance = mainCamera.aspect * mainCamera.orthographicSize;
        float xMax = currentCameraPosition.x + xDistance - boundSize.x;
        float xMin = currentCameraPosition.x - xDistance + boundSize.x;

        // Fix vertical bounds
        if (currentPosition.x < xMin || currentPosition.x > xMax)
        {
            currentPosition.x = Mathf.Clamp(currentPosition.x, xMin, xMax);
        }

        // Get Y distances.
        float yDistance = mainCamera.orthographicSize;
        float yMax = currentCameraPosition.y + yDistance - boundSize.y;
        float yMin = currentCameraPosition.y - yDistance + boundSize.y;

        // Fix vertical bounds
        if (currentPosition.y < yMin || currentPosition.y > yMax)
        {
            currentPosition.y = Mathf.Clamp(currentPosition.y, yMin, yMax);
        }

        // Set position.
        transform.position = currentPosition;
    }

    /// <summary>
    // Add force.
    /// </summary>
    public static void TryAddRigidbodyForce(this Transform transform, Vector2 force)
    {
        if (transform.rigidbody2D == null) return;

        transform.rigidbody2D.AddForce(force);
    }
}