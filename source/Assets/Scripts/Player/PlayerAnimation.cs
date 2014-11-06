using UnityEngine;
using System.Collections;

public class PlayerAnimation : BaseScript
{
    #region Fields

    /// <summary>
    /// Facing side parameter
    /// </summary>
    private const string FacingSideParameter = "FacingSide";
    /// <summary>
    /// Animator component.
    /// </summary>
    private Animator animator;
    /// <summary>
    /// Control the current sprite side.
    /// </summary>
    private FacingSide currentFacingSide;
    /// <summary>
    /// The original scale in x.
    /// </summary>
    private float originalScaleX;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        animator = GetComponent<Animator>();

        currentFacingSide = FacingSide.Down;

        originalScaleX = transform.localScale.x;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // Mouse position.
        Vector3 mousePosition = InputControl.GetMousePosition(transform.position, GameManager.Instance.MainCamera);
        //print(currentFacingSide + " - " + mousePosition);

        // To evaluate which animation.
        EvaluateAnimation(mousePosition);

        // To update current animation.
        UpdateAnimation();
    }

    /// <summary>
    /// Method to evaluate which animation will be setted.
    /// </summary>
    private void EvaluateAnimation(Vector2 mousePosition)
    {
        bool lookToSide = Mathf.Abs(mousePosition.x) > Mathf.Abs(mousePosition.y);

        if (lookToSide)
        {
            if (mousePosition.x >= transform.position.x)
            {
                currentFacingSide = FacingSide.Right;
            }
            else
            {
                currentFacingSide = FacingSide.Left;
            }
        }
        else
        {
            if (mousePosition.y >= transform.position.y)
            {
                currentFacingSide = FacingSide.Up;
            }
            else
            {
                currentFacingSide = FacingSide.Down;
            }
        }
    }

    /// <summary>
    /// Method to control animation.
    /// </summary>
    private void UpdateAnimation()
    {
        int parameter = Mathf.Abs((int)currentFacingSide);

        animator.SetInteger(FacingSideParameter, parameter);

        switch (currentFacingSide)
        {
            case FacingSide.Left:
                Flip(-1);
                break;
            default:
                Flip(1);
                break;
        }
    }

    /// <summary>
    /// Method to flip sprite.
    /// </summary>
    private void Flip(int xScale)
    {
        Vector2 scale = transform.localScale;
        scale.x = xScale * originalScaleX;
        transform.localScale = scale;
    }

    #endregion
}