using System;
using System.Threading.Tasks;
using RAGE;
using System.Collections.Generic;

namespace Client.Players
{
    public class KeyBind : RAGE.Events.Script
    {
        public KeyBind()
        {
            Events.Tick += Tick;
        }
        public void Tick(List<Events.TickNametagData> nametags)
        {
            RAGE.Input.Bind(113, true, ()=>
            {
                RAGE.Ui.Cursor.Visible = !RAGE.Ui.Cursor.Visible;
            });
        }

    }
}
