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

    ////// SHOT CHILDREN ELEMENTS
    ////public GameObject spriteShot;
    ////public GameObject feedbackCircle;
    ////private ParticleSystem feedbackParticles;
    ////public float feedbackDuration;
    ////private float _feedbackDuration;
    ////private bool isFeedbacksOn = false;

    #endregion

    #region Methods

    ///// <summary>
    ///// 
    ///// </summary>
    //void Start()
    //{
    //    feedbackParticles = gameObject.GetComponentInChildren<ParticleSystem>();
    //    feedbackParticles.time = -1;

    //    feedbackCircle.SetActive(false);
    //    spriteShot.SetActive(true);
    //}

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // If shot is not visible (outside of camera view).
        //if (!renderer.isVisible)
        //{
        //    // Return to pool.
        //    gameObject.SetActive(false);
        //}

        //if (_feedbackDuration > 0 && isFeedbacksOn)
        //{
        //    _feedbackDuration -= Time.deltaTime;
        //}
        //else if (_feedbackDuration < 0 && isFeedbacksOn)
        //{
        //    isFeedbacksOn = false;
        //    gameObject.SetActive(false);
        //}
    }

    /// <summary>
    /// Update game physikcs.
    /// </summary>
    void FixedUpdate()
    {
        // Add force through rigidbody.
        rigidbody2D.velocity = direction * speed;
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="other"></param>
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.transform.tag != GameSettings.PlayerTag)
    //    {
    //        feedbackParticles.time = feedbackDuration;
    //        feedbackParticles.Play();

    //        feedbackCircle.SetActive(true);

    //        speed = 0;
    //        rigidbody2D.velocity = Vector2.zero;

    //        spriteShot.SetActive(false);

    //        _feedbackDuration = feedbackDuration;
    //        isFeedbacksOn = true;
    //    }
    //}

    #endregion
}
