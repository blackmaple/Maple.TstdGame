
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
    /// class ["Assembly-CSharp.dll".""."CharacterAddStat"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000387U)]
    [ MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [67, 104, 97, 114, 97, 99, 116, 101, 114, 65, 100, 100, 83, 116, 97, 116])]
    
                
    // class 0x10 System.String id
     [MonoCollectorSearchFieldAttribute(typeof(PMonoString),"id", "ID")]
            
    // class 0x18 Tstd2.Framework.StatList addStat
     [MonoCollectorSearchFieldAttribute(typeof(StatList.Ptr_StatList),"addStat", "ADD_STAT")]
    public partial class CharacterAddStat
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "CharacterAddStat";
        //public static byte[] Static_ClassName { get; } = [67, 104, 97, 114, 97, 99, 116, 101, 114, 65, 100, 100, 83, 116, 97, 116];

        //public const uint Const_TypeToken = 0x02000387U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CharacterAddStat(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CharacterAddStat(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CharacterAddStat obj) => obj._ptr;
            public static implicit operator bool(Ptr_CharacterAddStat obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."CharacterAddStat"]
        /// </summary>
        public partial class CharacterAddStat
        { 

            
            
            /// <summary>
            ///   System.Void .ctor(System.String _id)
            /// </summary>
            /// <param name="_id">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR (nint _id);

            
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
            ///  extern nint CLONE ();
            
            

            
            /// public static partial class Search_CharacterAddStat
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}