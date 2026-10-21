using UnityEngine;

public class TextureMovement : MonoBehaviour
{
    private Vector2 offset;
    private Material material;
    public float speedX = 0.1f;
    private float curX;
    public bool isEnabled = true;
    private float curXR;
    
    public void SetActiveScript()
    {
        isEnabled = !isEnabled;
    }
    
    private void Start()
    {
        GameObject cylinder = GameObject.Find("Cylinder");
        material = cylinder.GetComponent<Renderer>().material;
        curX = cylinder.GetComponent<Renderer>().material.mainTextureOffset.x;
        
    }

    private void Update()
    {
        if (!isEnabled)
            return;
        
        curX += Time.deltaTime * speedX;
        material.mainTextureOffset = new Vector2(curX, 0);
        curXR = curX;
    }
}
