using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBehaviour
{
    void GoToPosition(Vector3 position);
    //void Chase(Vector2 position);
    void Attack();
    //void Block();
    void DeactiveProperties(bool value);

    void ReturnToBase();



}
