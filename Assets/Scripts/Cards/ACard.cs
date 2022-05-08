using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ACard : MonoBehaviour
{
    public CardData m_CardData;

    #region Override
    protected virtual void Start()
    {
        
    }
    protected virtual void Update()
    {

    }

    /// <summary>Called when this card gets added to the deck</summary>
    public virtual void AddCardToDeck() { }
    /// <summary>Called when any card gets added to the deck</summary>
    /// <param name="_card"><see cref="ACard"/> added. Can not be this card</param>
    public virtual void AddAnyCardToDeck(ACard _card) { }

    /// <summary>This card gets removed from the deck</summary>
    public virtual void RemoveCardFromDeck() { }
    /// <summary>Any card removed from the deck</summary>
    /// <param name="_card"><see cref="ACard"/> removed. Can not be this card</param>
    public virtual void RemoveAnyCardFromDeck(ACard _card) { }

    /// <summary>This card gets drawn to players hand</summary>
    public virtual void OnDrawCard() { }

    /// <summary>Card gets played</summary>
    public virtual void OnPlayCard() { }
    /// <summary>Any card gets played</summary>
    /// <param name="_card"><see cref="ACard"/> played. can not be this card</param>
    public virtual void OnAnyCardPlayed(ACard _card) { }

    /// <summary>This card gets discarted from hand to discard pile</summary>
    public virtual void OnDiscardCard() { }
    /// <summary>Any card gets discarted</summary>
    /// <param name="_card"><see cref="ACard"/> discarted. can not be this card</param>
    public virtual void OnAnyDiscardCard(ACard _card) { }

    /// <summary>Player hovers over this card</summary>
    public virtual void OnHoverCard() { }
    /// <summary>Player does not hover over this card anymore</summary>
    public virtual void OnUnhoverCard() { }

    /// <summary>Player select this card (like left click)</summary>
    public virtual void OnSelectCard() { }

    /// <summary>If this cards allow choosing enemies, this method calls if player hovers with selected card over an enemy</summary>
    public virtual void OnHoverOverEnemy() { }
    /// <summary>If this cards allow choosing enemies, this method calls if player stop hovering with selected card over an enemy</summary>
    public virtual void OnUnHoverOverEnemy() { }

    /// <summary>Deck gets shuffled</summary>
    public virtual void OnShuffleDeck() { }

    /// <summary>Card gets disposed</summary>
    public virtual void OnDisposeCard() { }
    #endregion


}
