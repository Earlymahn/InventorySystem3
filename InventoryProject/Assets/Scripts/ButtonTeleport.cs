using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public GameObject Item1;
    public Transform positions;
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any object
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the object hit has a specific tag (you can use any other identifier like name, layer, etc.)
                if (hit.collider.CompareTag("Clickable"))
                {
                    // Instantiate a new object at the hit point
                    InstantiateNewObject(hit.point);
                }
            }
        }
    }

    void InstantiateNewObject(Vector3 position)
    {
        // Instantiate your object here at the given position
        // For example:
        GameObject newObject = Instantiate(Item1, positions.position , Quaternion.identity);
    }
}
