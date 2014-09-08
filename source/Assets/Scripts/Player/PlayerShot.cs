using UnityEngine;
using System.Collections;

public class PlayerShot : BaseScript
{
    #region Fields

    /// <summary>
    /// Shot direction.
    /// </summary>
    [HideInInspector]
    public Vector2 direction;

    /// <summary>
    /// Shot speed.
    /// </summary>
    [SerializeField]
    public float speed;

    #endregion

    #region Methods

    void FixedUpdate()
    {
        rigidbody2D.AddForce(direction * speed);
    }

    #endregion
}
