using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public float moveSpeed;
  public float jumpForce;

  private bool isJumping;
  [SerializeField] private bool isGrounded;

  private float horizontalMovement;
  private float verticalMovement;
  private Vector3 velocity = Vector3.zero;

  public Transform groundCheck;
  public float groundCheckRadius;
  public LayerMask collisionLayers;

  public Rigidbody2D rb;
  public SpriteRenderer spriteRenderer;

  void Update()
  {
    horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;

    if(Input.GetButtonDown("Jump") && isGrounded)
    {
      isJumping = true;
    }

    Flip(rb.velocity.x);

    float characterVelocity = Mathf.Abs(rb.velocity.x);
  }

  void FixedUpdate()
  {
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);
    MovePlayer(horizontalMovement);
  }

  void MovePlayer(float _horizontalMovement)
  {
    Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
    rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

    if(isJumping == true)
    {
      rb.AddForce(new Vector2(0f, jumpForce));
      isJumping = false;
    }
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

  private void OnDrawGizmos()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
  }
}
