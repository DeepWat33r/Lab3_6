using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] private float Speed;
    [SerializeField] private string PlayerTag;
    public Vector3 finishPos;
    public float speed = 0.1f;
    private Vector3 _startPos;
    private float _trackPercent = 0;
    private int _direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.position;
        finishPos = new Vector3(_startPos.x, _startPos.y + 0.5f, _startPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        _trackPercent += _direction * speed * Time.fixedDeltaTime;
        float y = (finishPos.y - _startPos.y) * _trackPercent + _startPos.y;
        transform.position = new Vector3(_startPos.x, y, _startPos.z);
        if ((_direction == 1 && _trackPercent > .9f) || (_direction == -1 && _trackPercent < .1f)) _direction *= -1;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            player.GemCollected++;
            Destroy(this.gameObject);
        }
    }
}
