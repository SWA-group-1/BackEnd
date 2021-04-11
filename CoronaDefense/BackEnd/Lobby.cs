// <copyright file="Lobby.cs" company="NTNU: SWA group 1 (2021)">
// Copyright (c) NTNU: SWA group 1 (2021). All rights reserved.
// </copyright>

using API.Requests;
using API.Schemas;
using BackEnd.Router;
using System.Collections.Generic;

namespace BackEnd
{
  /// <summary>
  /// Model of a game-instance. Contains all the state for one running instance of the game.
  /// </summary>
  internal class Lobby : IReceiver
  {
    /// <summary>
    /// Gets the ID of this <see cref="Lobby"/>.
    /// </summary>
    public long Id { get; }

    /// <summary>
    /// Gets the name of this <see cref="Lobby"/>.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets password of this <see cref="Lobby"/>.
    /// </summary>
    private string Password { get; }

    /// <summary>
    /// Gets the number of players, or clients, currently connected to this <see cref="Lobby"/>.
    /// </summary>
    public int PlayerCount { get; private set; } = 0;

    private List<IObserver> Observers { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Lobby"/> class.
    /// </summary>
    /// <param name="name">Name of the new <see cref="Lobby"/>.</param>
    /// <param name="password">Password of the new <see cref="Lobby"/>.</param>
    /// <param name="router">Router the new <see cref="Lobby"/> should connect to.</param>
    public Lobby(string name, string password, Router.Router router)
    {
      this.Id = router.Register(this);
      this.Name = name;
      this.Password = password;
    }

    /// <inheritdoc/>
    public void ActivateClient(LocalRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public JoinLobbyResult JoinLobby(JoinLobbyRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public void LeaveLobby(LocalRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public LobbyResult GetLobby(LobbyRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public void PlaceTower(PlaceTowerRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public void SellTower(SelltowerRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public void StartGame(StartGameRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc/>
    public void StartRound(LocalRequest request)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Add observer to this Lobby.
    /// </summary>
    public void addObserver(IObserver observer)
    {
      this.Observers.Add(observer);
    }

    /// <summary>
    /// Observer that reacts to a selection of events that can befall a <see cref="Lobby"/>
    /// </summary>
    public interface IObserver
    {
      /// <summary>
      /// Observer gets an opportunity to react to a <see cref="Lobby"/> closing.
      /// </summary>
      /// <param name="lobbyId"/>ID of lobby that closed.</param>
      void OnClose(long lobbyId);
    }
  }
}
