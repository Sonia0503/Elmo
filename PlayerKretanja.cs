using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKretanja : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Animator myAnimator;
    private Collider2D myCollider;
    
    GameObject Laz;
    public GameObject getLaz;

    [SerializeField]
    private float movmentSpeed;
    private bool slide;
    public float damage;
    public bool jea;
    

    [SerializeField]
    public LayerMask whatIsJea;

    [SerializeField]
    private Transform [] groundPoints;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;

    private bool isGrounded;
    private bool jump;
    
    private float land;

    [SerializeField]
    private bool airControl;



    [SerializeField]
    private float jumpForce;


    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();

    }
    void Update()
    {
        HandleInput();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        jea = Physics2D.IsTouchingLayers(myCollider, whatIsJea);
        myAnimator.SetBool("Damage", jea);
        isGrounded = IsGrounded();
        HandleMovement();
        HandleLayers();
        ResetValues();
    }

    private void HandleMovement()

    {
         myRigidbody.velocity = Vector2.right * movmentSpeed; 

        if(myRigidbody.velocity.y < 0)
        { myAnimator.SetBool("land", true);
            
        }

        if (isGrounded && jump)
        {
            isGrounded = false;
            
            
            myRigidbody.AddForce(new Vector2(0, jumpForce));
         
        }

            if (slide && !this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Elmo_Crouch"))
        { myAnimator.SetBool("slide", true); }

        else if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Elmo_Crouch"))
        { myAnimator.SetBool("slide", false); }

      

    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.S))
        { slide = true; }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetTrigger("jump");
            jump = true; }
    }


    public void BtnJump()
    {
        myAnimator.SetTrigger("jump");
        jump = true;
    }

    public void BtnSlide()
    {
        myAnimator.SetTrigger("slide");
        slide = true;
    }


    private void ResetValues()
    {
        slide = false;
        jump = false;
        
        
    }

    private bool IsGrounded()
    {
        if (myRigidbody.velocity.y == 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);
                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        myAnimator.ResetTrigger("jump");
                        myAnimator.SetBool("land", false);
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private void HandleLayers()
    { if (!isGrounded)
        { myAnimator.SetLayerWeight(1, 1); }

    else
        { myAnimator.SetLayerWeight(1, 0); }
    }

    private void OnDestroy()
    {
        if (jea)
        {
            getLaz = GameObject.FindWithTag("Laz");
          
            Destroy(getLaz);



        }
    }



}
