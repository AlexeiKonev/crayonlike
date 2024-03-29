using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {
    public GameObject linePrefab;
    public GameObject currentLine;

    public EdgeCollider2D edgeCollider;
    public LineRenderer lineRenderer;
    public List<Vector2> fingerPositions;
    public float pointDrawDistance = 0.1f;

    private void CreateLine() {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPositions.Clear();
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, fingerPositions[0]);
        lineRenderer.SetPosition(1, fingerPositions[1]);
        edgeCollider.points = fingerPositions.ToArray();
    }
    private void UpdateLine(Vector2 newFingerPos) {
        fingerPositions.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);


        edgeCollider.points = fingerPositions.ToArray();

    }


    // Update is called once per frame
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            CreateLine();
        }
        if (Input.GetMouseButton(0)) {
            Vector2 temFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(temFingerPos, fingerPositions[fingerPositions.Count - 1]) > pointDrawDistance) {
                UpdateLine(temFingerPos);
            }
        }

    }
}
