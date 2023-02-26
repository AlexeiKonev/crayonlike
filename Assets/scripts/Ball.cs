using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 spawnPosition;
    void Start() {
        spawnPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    public void UpdatePosition() {
        gameObject.transform.position = spawnPosition;
    }
}
