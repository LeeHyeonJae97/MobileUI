using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableImage : Image
{
    public bool interactable
    {
        get { return _interactable; }

        set
        {
            _interactable = value;

            color = _interactable ? NormalColor : DisabledColor;
        }
    }

    public Color BaseColor => _baseColor;
    public Color NormalColor => _baseColor * _normalColor;
    public Color PressedColor => _baseColor * _pressedColor;
    public Color DisabledColor => _baseColor * _disabledColor;

    [SerializeField] private Color _baseColor = Color.white;
    [SerializeField] private Color _normalColor = Color.white;
    [SerializeField] private Color _pressedColor = Color.white;
    [SerializeField] private Color _disabledColor = Color.white;
    private bool _interactable;
}
