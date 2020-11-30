using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;
using Client;
using RAGETimer.Shared;

namespace Client.Authorization
{
    public class Authorization : Events.Script
    {
        public Authorization()
        {
            Events.OnBrowserDomReady += OnBrowserDomReady;
            CEF.Create();
            CEF.ShowLoginCEF();
            new Timer(() =>
            {
                RAGE.Ui.Cursor.Visible = true;
                Chat.Output("TIMER!");

            }, 150, 1);
        }
        public void OnBrowserDomReady(RAGE.Ui.HtmlWindow window)
        {
            //RAGE.Ui.Cursor.Visible = true;
        }
    }
}