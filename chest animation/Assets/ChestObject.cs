using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChestObject : MonoBehaviour
{
    public ChestAnim chestAnim;
    public GameObject chestLid;
    private void OnMouseEnter()
    {
        chestAnim.chestObject = this.gameObject;
    }

    private void OnMouseExit()
    {
        chestAnim.chestObject = null;
        chestAnim.ReturntoOG(gameObject);
    }

    private void OnMouseDown()
    {
        chestAnim.OpenChestAnim(this.gameObject, chestLid);
    }

}
