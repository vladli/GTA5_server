using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;
using Client;

namespace Client.Authorization
{
    public class CharacterList : Events.Script
    {
        public CharacterList()
        {
            Events.Add("Client.Authorization.ShowCharacters", ShowCharacters);
            Events.Add("Client.Authorization.AddCharacterToList", AddCharacterToList);
            Events.Add("Client.Authorization.ChoseCharacter", ChoseCharacters);
            Events.Add("Client.Authorization.DeleteCharacter", DeleteCharacter);
        }
        private void ShowCharacters(object[] args)
        {
            RAGE.Ui.Cursor.ShowCursor(true, true);
            CEF.ChangePage("Character");
        }
        private void AddCharacterToList(object[] args)
        {
            Chat.Output($"{ args[0]}, { args[1]}, { args[2]}, { args[3]}");
            CEF.Call($"AddCharacterToList('{args[0]}', '{args[1]}', '{args[2]}', '{args[3]}')");
        }
        private void ChoseCharacters(object[] args)
        {
            Events.CallRemote("Server.Player.Authorization.ChoseCharacter", args[0]);
            RAGE.Nametags.Enabled = true;
            CEF.ShowMainCEF();
        }
        private void DeleteCharacter(object[] args)
        {
            Events.CallRemote("Server.Player.Authorization.DeleteCharacter", args[0], args[1], args[2]);
        }
    }
}