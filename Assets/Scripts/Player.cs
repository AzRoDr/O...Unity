using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float gravity = -9.8f;
   public float strenght = 5f;
   public Sprite[] sprites;
   
   private SpriteRenderer _spriteRenderer;
   private Vector3 _direction;
   private int _spriteIndex;

   private void Start()
   {
      InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
   }


   private void Awake()
   {
      _spriteRenderer = GetComponent<SpriteRenderer>();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
      {
         _direction = Vector3.up * strenght;
         
      }

      _direction.y += gravity * Time.deltaTime;
      transform.position += _direction * Time.deltaTime;

   }

   private void AnimateSprite()
   {
      _spriteIndex++;

      if (_spriteIndex >= sprites.Length)
      {
         _spriteIndex = 0;
      }

      _spriteRenderer.sprite = sprites[_spriteIndex];
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.tag == "Obstacle")
      {
         FindObjectOfType<GameManager>().GameOver();
      }
      else if (other.gameObject.tag == "Score")
      {
         FindObjectOfType<GameManager>().IncreaseScore();
      }
   }
}
