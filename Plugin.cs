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
                { "genesis", "Genesis" },
                { "HP_Left", "Holdable Pad" },
                { "GrateVersion", "Grate" },
                { "void", "Void" },
                { "BANANAOS", "Banana OS" },
                { "GC", "Gorilla Craft" },
                { "CarName", "Gorilla Vehicles" },
                { "6p72ly3j85pau2g9mda6ib8px", "CCM V2" },
                { "FPS-Nametags for Zlothy", "FPS Tags" },
                { "cronos", "Cronos" },
                { "ORBIT", "Orbit" },
                { "Violet On Top", "Violet" },
                { "MP25", "Monke Phone" },
                { "GorillaWatch", "Gorilla Watch" },
                { "InfoWatch", "Gorilla Info Watch" },
                { "BananaPhone", "Banana Phone" },
                { "Vivid", "Vivid" },
                { "RGBA", "Custom Cosmetics" },
                { "cheese is gouda", "Whos Icheating" },
                { "shirtversion", "Gorilla Shirts" },
                { "gpronouns", "Gorilla Pronouns" },
                { "gfaces", "Gorilla Faces" },
                { "monkephone", "Monke Phone" },
                { "pmversion", "Player Models" },
                { "gtrials", "Gorilla Trials" },
                { "msp", "Monke Smartphone" },
                { "gorillastats", "Gorilla Stats" },
                { "using gorilladrift", "Gorilla Drift" },
                { "monkehavocversion", "Monke Havoc" },
                { "tictactoe", "Tic Tac Toe" },
                { "ccolor", "Index" },
                { "imposter", "Gorilla Among Us" },
                { "spectapeversion", "Spec Tape" },
                { "cats", "Cats" },
                { "made by biotest05 :3", "Dogs" },
                { "fys cool magic mod", "Fys Magic Mod" },
                { "colour", "Custom Cosmetics" },
                { "chainedtogether", "Chained Together" },
                { "goofywalkversion", "Goofy Walk" },
                { "void_menu_open", "Void" },
                { "violetpaiduser", "Violet Paid" },
                { "violetfree", "Violet Free" },
                { "obsidianmc", "Obsidian.Lol" },
                { "dark", "Shiba GT Dark" },
                { "hidden menu", "Hidden" },
                { "oblivionuser", "Oblivion" },
                { "hgrehngio889584739_hugb\n", "Resurgence" },
                { "eyerock reborn", "Eye Rock" },
                { "asteroidlite", "Asteroid Lite" },
                { "elux", "Elux" },
                { "cokecosmetics", "Coke Cosmetx" },
                { "GFaces", "G Faces" },
                { "github.com/maroon-shadow/SimpleBoards", "Simple Boards" },
                { "ObsidianMC", "Obsidian" },
                { "hgrehngio889584739_hugb", "Resurgence" },
                { "GTrials", "G Trials" },
                { "github.com/ZlothY29IQ/GorillaMediaDisplay", "Gorilla Media Display" },
                { "github.com/ZlothY29IQ/TooMuchInfo", "Too Much Info" },
                { "github.com/ZlothY29IQ/RoomUtils-IW", "Room Utils IW" },
                { "github.com/ZlothY29IQ/MonkeClick", "Monke Click" },
                { "github.com/ZlothY29IQ/MonkeClick-CI", "Monke Click CI" },
                { "github.com/ZlothY29IQ/MonkeRealism", "Monke Realism" },
                { "MediaPad", "Media Pad" },
                { "GorillaCinema", "Gorilla Cinema" },
                { "ChainedTogetherActive", "Chained Together" },
                { "GPronouns", "G Pronouns" },
                { "CSVersion", "Custom Skin" },
                { "github.com/ZlothY29IQ/Zloth-RecRoomRig", "Zloth Rec Room Rig" },
                { "ShirtProperties", "Shirts Old" },
                { "GorillaShirts", "Shirts" },
                { "GS", "Old Shirts" },
                { "6XpyykmrCthKhFeUfkYGxv7xnXpoe2", "CCM V2" },
                { "Body Tracking", "Body Track Old" },
                { "Body Estimation", "Han Body Est" },
                { "Gorilla Track", "Body Track" },
                { "CustomMaterial", "Custom Cosmetics" },
                { "I like cheese", "Rec Room Rig" },
                { "silliness", "Silliness" },
                { "EmoteWheel", "Fortnite Emote Wheel" },
                { "untitled", "Untitled" }
            };

            PhotonNetwork.LocalPlayer.SetCustomProperties(properties);
        }
    }
}
