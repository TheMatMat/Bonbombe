using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public float moveSpeed;

  private float horizontalMovement;
  private Vector3 velocity = Vector3.zero;

  public Rigidbody2D rb;
  public SpriteRenderer spriteRenderer;

  void Update()
  {
    horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;

    Flip(rb.velocity.x);

    float characterVelocity = Mathf.Abs(rb.velocity.x);
  }

  void FixedUpdate()
  {
    MovePlayer(horizontalMovement);
  }

  void MovePlayer(float _horizontalMovement)
  {
    Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
    rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
  }

  void Flip(float _velocity)
  {
    if(_velocity > 0.1f)
    {
      spriteRenderer.flipX = false;
    }
    else if(_velocity < -0.1f)
    {
      spriteRenderer.flipX = true;
    }
  }
}
