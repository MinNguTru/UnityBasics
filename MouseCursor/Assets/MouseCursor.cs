 using UnityEngine;

 public class MouseCursor : MonoBehaviour
 {
     public SpriteRenderer rend;
     public Sprite defaultCursor;
     public Sprite tempCursor;

     void Start()
     {
         Cursor.visible = false;
         rend = GetComponent<SpriteRenderer>();
     }

     void Update()
     {
         Cursor.visible = false;
         Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         transform.position = cursorPos;

         if (Input.GetKeyDown(KeyCode.W))
         {
             rend.sprite = tempCursor;
         } else if (Input.GetKeyDown(KeyCode.S))
         {
             rend.sprite = defaultCursor;
         }
     }
 }
