using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowMenu : MonoBehaviour
{
    public Behaviour menu_canvas;
    public Behaviour paint_canvas;
    public Behaviour ilum_canvas;

    private bool canvas_active = false;

    // Start is called before the first frame update
    void Start()
    {
        canvas_active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            canvas_active = !canvas_active;

            menu_canvas.enabled = canvas_active;
            paint_canvas.enabled = canvas_active;
            ilum_canvas.enabled = canvas_active;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            menu_canvas.enabled = true;
            paint_canvas.enabled = false;
            ilum_canvas.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            menu_canvas.enabled = false;
            paint_canvas.enabled = true;
            ilum_canvas.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            menu_canvas.enabled = false;
            paint_canvas.enabled = false;
            ilum_canvas.enabled = true;
        }
    }
}
