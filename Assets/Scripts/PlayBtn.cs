using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayBtn : MonoBehaviour,IPointerClickHandler {
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.gameObject.name == "Button - Play")
            FuncoesGenericas.instance.ChangeScene("Fase_1");
        else
            print(this.gameObject.name);
    }
}
