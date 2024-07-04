using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementPlayer : MonoBehaviour
{
    protected Rigidbody2D rb2D;
    public Vector2 velocity = new Vector2(0, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speedUp = 0.5f;
    public float speedMax = 20f;
    public float speedHorizontal = 3f;
    public float speedDown = 0.5f;
    public bool autoRun = true;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
    }
    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");

        if (autoRun) this.pressVertical = 1;
    }
    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }
    protected virtual void UpdateSpeed()
    {
        this.velocity.x = pressHorizontal * speedHorizontal;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();

        this.rb2D.MovePosition(this.rb2D.position + velocity * Time.fixedDeltaTime);
    }
    protected virtual void UpdateSpeedUp()
    {

        if (this.pressVertical <= 0) return;

        this.velocity.y += this.speedUp;

        if (this.velocity.y >= speedMax) this.velocity.y = this.speedMax;

        if (transform.position.x < -7 || transform.position.x > 7)
        {
            this.velocity.y -= 1f;
            if (this.velocity.y <= 3f) this.velocity.y = 3f;
        }
    }
    protected virtual void UpdateSpeedDown()
    {
        if (this.pressVertical != 0) return;

        this.velocity.y -= this.speedDown;
        if (this.velocity.y <= 0) this.velocity.y = 0;

    }
}
