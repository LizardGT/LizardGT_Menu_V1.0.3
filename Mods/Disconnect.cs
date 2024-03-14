using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Disconnect
    {

        

        public static void DisconnectFromLobby() // DISCONNECTS YOU FROM LOBBY
        {
            PhotonNetwork.Disconnect();
        }
        public static void JoinRandomPublic()  // JOINS A RANDOM PUB
        {
            PhotonNetwork.JoinRandomRoom();
        }
        public static void QUITGTAG()  // QUITS THE GAME
        {
            UnityEngine.Application.Quit();
        }
        public static void EUServers()  //Takes You To A EU SERVER
        {
            PhotonNetwork.ConnectToRegion("eu");
            PhotonNetwork.JoinRandomRoom();
        }

        public static void USServers()  //Takes You To A US SERVER
        {
            PhotonNetwork.ConnectToRegion("us");
            PhotonNetwork.JoinRandomRoom();
        }

        public static void USWServers()  //Takes You To A USW SERVER
        {
            PhotonNetwork.ConnectToRegion("usw");
            PhotonNetwork.JoinRandomRoom();
        }

        public static void RestartGame()
        {
            Process.Start("steam://rungameid/1533390");
            Application.Quit();
        }

        //ROOM JOINERS
        public static string rejRoom = null;
        public static float rejDebounce = 0f;

        public static void AutoJoinRoomRUN()
        {
            rejRoom = "RUN";
            rejDebounce = Time.time + 2f;
        }

        public static void AutoJoinRoomDAISY()
        {
            rejRoom = "DAISY";
            rejDebounce = Time.time + 2f;
        }

        public static void AutoJoinRoomDAISY09()
        {
            rejRoom = "DAISY09";
            rejDebounce = Time.time + 2f;
        }

        public static void AutoJoinRoomPBBV()
        {
            rejRoom = "PBBV";
            rejDebounce = Time.time + 2f;
        }

        public static void AutoJoinRoomBOT()
        {
            rejRoom = "BOT";
            rejDebounce = Time.time + 2f;
        }
        //---------------------------------------
    }
}
