using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IColisao : IEventSystemHandler
{
    // Methods that will be called via Send should return IEnumerable
    IEnumerable ApplyColisao(bool colidi);

    bool? GetColisao();
}