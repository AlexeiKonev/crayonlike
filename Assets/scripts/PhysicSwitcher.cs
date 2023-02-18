using UnityEngine;

public class PhysicSwitcher : MonoBehaviour {
    public GameObject ball;
    public Rigidbody2D rb2D;
    void Start() {
        ball = GameObject.Find("Ball");
        rb2D = ball.GetComponent<Rigidbody2D>();
    }
    public void SwitchOnPhysics() {

        rb2D.bodyType = RigidbodyType2D.Dynamic;
    }
    public void SwitchOffPhysics() {

        rb2D.bodyType = RigidbodyType2D.Static;
    }
}
