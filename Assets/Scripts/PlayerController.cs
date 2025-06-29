using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool isGrounded;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        if (move != 0)
            sr.flipX = move < 0;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

        // Takılma engelleme
        bool isStuck = !isGrounded && rb.linearVelocity.y < 0.1f && Mathf.Abs(rb.linearVelocity.x) < 0.05f;
        if (isStuck)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -2f);
        // Düşüşte ekstra yerçekimi uygula (daha hızlı düşüş için)
        // Düşüş sırasında ekstra yerçekimi kuvveti uygula
        if (!isGrounded && rb.linearVelocity.y < 0)
        {
            // Havadaysa ve düşüşe geçmişse → hızlı düş
            rb.gravityScale = 4.5f;
        }
        else if (!isGrounded && rb.linearVelocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            // Zıplıyor ama Space bırakılmış → kısa kes
            rb.gravityScale = 3f;
        }
        else
        {
            // Normal durum (yerdeyken veya Space'e basılı zıplarken)
            rb.gravityScale = 2f;
        }
    }
}
