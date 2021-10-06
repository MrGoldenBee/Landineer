using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlacingScript : MonoBehaviour
{
    //Placing
    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;


    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer);

            if (rayHit.collider == null)
            {
                Instantiate(finalObject, transform.position, Quaternion.identity);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayBreakHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer);
            if (rayBreakHit.collider != null && rayBreakHit.collider.gameObject.tag == "Blocks")
            {
                Destroy(rayBreakHit.collider.gameObject);
            }
        }
    }

}
