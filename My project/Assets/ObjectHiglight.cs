using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectHiglight : MonoBehaviour
{
    Color m_MouseOverColor = Color.red;
    Color m_OriginalColor;
    MeshRenderer m_Renderer;
    public string calificacion;
    public string description;
    private TextMeshProUGUI textMesh;
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
        GameObject go = GameObject.FindWithTag("objDesc");
        GameObject co = GameObject.FindWithTag("square");
        canvas = co.GetComponent<Canvas>();
        textMesh = go.GetComponent<TextMeshProUGUI>();
        canvas.enabled = false;
        textMesh.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        m_Renderer.material.SetColor("_Color", Color.red);
        m_Renderer.material.color = m_MouseOverColor;
        SetText();
    }

    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
        SetNoText();
    }
    
    public void SetText() {
      textMesh.text = calificacion + "\n" + description;
      canvas.enabled = true;
    }

    public void SetNoText() {
      textMesh.text = "";
      canvas.enabled = false;
    }
}
