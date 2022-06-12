using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    int counter = 0;
    bool alive = true;
  
    public float speed = 5;
    [SerializeField] Rigidbody rb;
    
    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;
    
    public float speedIncreasePerPoint = 0.1f;
    // jugador avanza constantemente, incrementando su velocidad de a poco para subir dificultad a medida que pasa el tiempo
    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
    // si el jugador se sale del mapa y cae, luego de unos segundo revivira desde el comienzo
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }
        
    }

    public void Die()
    {
        
        alive = false;
        Invoke("Restart", 4);
    }

    void Restart()
    {
        
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
               
            
        
    }
}