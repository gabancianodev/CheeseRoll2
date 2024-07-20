using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("REFERENCES")]
    [SerializeField] private Rigidbody2D m_RigidBody;
    [Space]
    [SerializeField] private BoxCollider2D m_Collider;


   private void Start() {

   }

   private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            
        }
   }
}
