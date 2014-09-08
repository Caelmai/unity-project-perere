using UnityEngine;
using System.Collections;

public class PlayerWeapon : BaseWeapon
{
    #region Fields


    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // Mouse position.
        Vector2 mousePosition = InputControl.GetMousePosition(mainCamera);
        // Set target position.
        transform.position = mousePosition;

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
