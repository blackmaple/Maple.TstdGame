
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.TstdMetadata
{
    
    
    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Characters"."Immunity"]
    /// </summary>
    public enum Immunity : System.Int32
    { 

        
        Betray = 0x00000001,

        Assassinate = 0x00000002,

        Silent = 0x00000004,

        Dare = 0x00000008,

        Disable = 0x00000010,

        BufSkill = 0x00000FFF,

        Trap = 0x00001000,

        Fire = 0x00002000,

        Water = 0x00004000,

        Stone = 0x00008000,

        Thrunder = 0x00010000,

        Attack = 0x00080000,

    }


}