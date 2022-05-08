using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CardData")]
public class CardData : ScriptableObject
{
    [SerializeField]
    private string m_CardName;
    public string CardName 
    { 
        get => m_CardName;
        set => m_CardName = value;
    }
    [SerializeField]
    private byte m_PlayCost;
    public byte PlayCost
    {
        get => m_PlayCost;
        set => m_PlayCost = value;
    }
    [SerializeField]
    private string m_CardDescription;
    public string CardDescription
    {
        get => m_CardDescription;
        set => m_CardDescription = value;
    }
    [SerializeField]
    private CARDTYPE m_CardType;
    public CARDTYPE CardType
    {
        get => m_CardType;
        set => m_CardType = value;
    }

    #region Attack and Defence
    [SerializeField]
    private ushort m_BaseDamage;
    public ushort BaseDamage
    {
        get => m_BaseDamage;
        set => m_BaseDamage = value;
    }
    [SerializeField]
    private bool m_CanAttack;
    public bool CanAttack
    {
        get => m_CanAttack;
        set => m_CanAttack = value;
    }

    [SerializeField]
    private ushort m_BaseBlock;
    public ushort BaseBlock
    {
        get => m_BaseBlock;
        set => m_BaseBlock = value;
    }
    [SerializeField]
    private bool m_CanBlock;
    public bool CanBlock
    {
        get => m_CanBlock;
        set => m_CanBlock = value;
    }
    #endregion

}

public enum CARDTYPE
{
    UNDEFINED,
    NONE,
    ATTACK,
    SKILL,
    POWER,
    STATUS,
    CURSE
}