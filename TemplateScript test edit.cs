using UnityEngine;
using System.Collections;

public class TemplateScript : MonoBehaviour {

    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;
	
	// Update is called once per frame
	void Update ()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            RaycastHit2D rayHit = Physics2D.Raycast(mouseRay, Vector2.zero, Mathf.Infinity, allTilesLayer);

            if (rayHit.collider == null)
            {
                Instantiate(finalObject, transform.position, Quaternion.identity);
            }
        }

        if (Input.GetKeyDown(KeyCode.q))
        {
            Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            RaycastHit2D raynoHit = Physics2D.Raycast(mouseRay, Vector2.zero, Mathf.Infinity, allTilesLayer);

            if (raynoHit.collider.tag == "dirt")
            {
                Debug.Log("dirt dtected");
                Destroy(raynoHit.collider.GameObject);
            }
        }
    }
}