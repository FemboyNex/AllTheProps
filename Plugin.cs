using BepInEx;
using GorillaLocomotion;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using ExitGames.Client.Photon;

namespace AllTheProps
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();

            Hashtable properties = new Hashtable
            {
                { "GFaces", "GFaces" },
                { "github.com/maroon-shadow/SimpleBoards", "Simple Boards" },
                { "github.com/ZlothY29IQ/GorillaMediaDisplay", "GMD" },
                { "GTrials", "GTrials" },
                { "github.com/ZlothY29IQ/TooMuchInfo", "TMI Zlothy" },
                { "github.com/ZlothY29IQ/RoomUtils-IW", "Room Utils" },
                { "github.com/ZlothY29IQ/MonkeClick", "Monke Click" },
                { "github.com/ZlothY29IQ/MonkeClick-CI", "Monke Click CI" },
                { "github.com/ZlothY29IQ/MonkeRealism", "Monke Realism" },
                { "MediaPad", "Media Pad" },
                { "GorillaCinema", "GCinema" },
                { "FPS-Nametags for Zlothy", "FPS Nametags" },
                { "ChainedTogetherActive", "Chained Together" },
                { "GPronouns", "GPronouns" },
                { "CSVersion", "Custom Skin" },
                { "github.com/ZlothY29IQ/Zloth-RecRoomRig", "Zlothy Body Estimation" },
                { "ShirtProperties", "GShirts Old" },
                { "GorillaShirts", "GShirts" },
                { "GS", "Old GShirts" },
                { "HP_Left", "Holdable Pad" },
                { "GrateVersion", "Grate" },
                { "BananaOS", "BananaOS" },
                { "GC", "GCraft" },
                { "CarName", "Vehicles" },
                { "MonkePhone", "Monke Phone" },
                { "Body Tracking", "Body Tracking" },
                { "Gorilla Track", "GTrack" },
                { "GorillaWatch", "GWatch" },
                { "InfoWatch", "Info Watch" },
                { "BananaPhone", "Banana Phone" },
                { "CustomMaterial", "Custom Cosmetics" },
                { "cheese is gouda", "WhoIsThatMonke" },
                { "WhoIsThatMonke", "WhoIsThatMonke Recode" },
                { "I like cheese", "awawe" },
                { "GorillaNametags", "GNametags" },
                { "DeeTags", "Dee Tags" },
                { "Boy Do I Love Information", "BDILI" },
                { "NametagsPlusPlus", "Nametags++" },
                { "WalkSimulator", "WalkSim ZlothY Fix" },
                { "kingbingus.oculusreportmenu", "ORM" },
                { "Dingus", "dingus" },
                { "Graze Heath System", "Health System" },
                { "Gorilla Track Packed", "Gorilla Track" },
            };

            PhotonNetwork.LocalPlayer.SetCustomProperties(properties);
        }
    }
}
