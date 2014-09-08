using UnityEngine;
using System.Collections;

public class PlayerWeapon : BaseWeapon
{
    #region Fields

    private Vector2 moveDirection;

    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        //Vector2 currentPosition = transform.position;

        // Mouse position.
        Vector2 mousePosition = InputControl.GetMousePosition(mainCamera);

        //moveDirection = mousePosition - currentPosition;
        //moveDirection.Normalize();

        //Vector2 target = moveDirection + currentPosition;
        //transform.position = Vector3.Lerp(currentPosition, target, 10 * Time.deltaTime);

        // Set target position.
        transform.position = mousePosition;
        // Enforce player inside the screen.
        transform.EnforceBounds(mainCamera, renderer);

        // If shot button is pressed.
        if (InputControl.IsShotEnabled)
        {
            // Get new shot.
            GameObject shot = GetObjectFromPool(player.transform.position);

            // Set direction.
            PlayerShot playerShot = shot.GetComponent<PlayerShot>();
            playerShot.direction = transform.position;
        }
    }

    #endregion
}
