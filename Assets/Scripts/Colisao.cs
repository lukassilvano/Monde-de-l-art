using UnityEngine;
using System.Collections;

public class Colisao : MonoBehaviour, IColisao
{
    public bool _Colisao = false;

    public IEnumerable ApplyColisao(bool colidi)
    {
        _Colisao = colidi;
        Debug.Log("Tira acertou uma slime: " + _Colisao);
        yield break;
    }

    public bool? GetColisao()
    {
        return _Colisao;
    }
}
