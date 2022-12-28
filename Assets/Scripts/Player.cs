using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private string MushroomTag;
    public int GemCollected = 0;
    public IPlayerColorState ColorState { get; set; } = new PlayerWhiteState();
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        GemCollected = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(MushroomTag))
        {
            ColorState.ChangeColor(this);
        }
    }
    public void ChangeSpriteRendererColor(Color color)
    {
        _spriteRenderer.color = color;
    }
}