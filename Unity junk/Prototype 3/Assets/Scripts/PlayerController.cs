using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpforce = 10f, gravityModifier;
    public bool isonground = true, gameover = false;
    public ParticleSystem explosionParticle, dirtParticle;
    public AudioClip crashSound, jumpSound;
    
    private Rigidbody playerRB;
    private Animator playerAnim;
    private AudioSource playerAudio;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground &&! gameover)
        {
            playerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isonground = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isonground = true;
            dirtParticle.Stop();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameover = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
