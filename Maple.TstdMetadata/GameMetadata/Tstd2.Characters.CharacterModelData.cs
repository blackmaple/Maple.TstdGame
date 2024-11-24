
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Characters"."CharacterModelData"]
    /// [Tstd2.Manager.TagResource]=>[CloneableObject]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000249U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [67, 104, 97, 114, 97, 99, 116, 101, 114, 77, 111, 100, 101, 108, 68, 97, 116, 97])]


    // class 0x10 System.String tag
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "tag", "TAG")]

    // struct 0x18 System.Int32 id
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "id", "ID")]

    // class 0x20 UnityEngine.Sprite profile
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"profile", "PROFILE")]

    // class 0x28 System.String profilePath
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"profilePath", "PROFILE_PATH")]

    // class 0x30 System.String characterName
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "characterName", "CHARACTER_NAME")]

    // class 0x38 System.String styleName
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "styleName", "STYLE_NAME")]

    // class 0x40 UnityEngine.Texture2D modelTexture
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"modelTexture", "MODEL_TEXTURE")]

    // class 0x48 System.String texturePath
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"texturePath", "TEXTURE_PATH")]

    // class 0x50 System.String modelPaletteTag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"modelPaletteTag", "MODEL_PALETTE_TAG")]

    // class 0x58 Tstd2.Characters.CharacterModelPalette modelPalette
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"modelPalette", "MODEL_PALETTE")]

    // class 0x60 System.Collections.Generic.List<System.Single> attackXOffsets
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"attackXOffsets", "ATTACK_X_OFFSETS")]

    // struct 0x68 System.Int32 readyX
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"readyX", "READY_X")]
    public partial class CharacterModelData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Characters";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115];

        //public const string Const_ClassName = "CharacterModelData";
        //public static byte[] Static_ClassName { get; } = [67, 104, 97, 114, 97, 99, 116, 101, 114, 77, 111, 100, 101, 108, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000249U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CharacterModelData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CharacterModelData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CharacterModelData obj) => obj._ptr;
            public static implicit operator bool(Ptr_CharacterModelData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Characters"."CharacterModelData"]
    /// </summary>
    public partial class CharacterModelData
    {



        /// <summary>
        ///   System.Object Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   UnityEngine.Texture2D get_ModelTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ModelTexture")]
        ///  extern nint GET_MODEL_TEXTURE ();


        /// <summary>
        ///   Tstd2.Characters.CharacterModelPalette get_Palette()
        /// </summary>
        /// <returns>class Tstd2.Characters.CharacterModelPalette</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Palette")]
        ///  extern nint GET_PALETTE ();


        /// <summary>
        ///   UnityEngine.Sprite get_Profile()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Profile")]
        ///  extern nint GET_PROFILE ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_CharacterModelData))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_CharacterModelData))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_CharacterModelData))]
        ///  extern void .CTOR_02 ();


        /// public static partial class Search_CharacterModelData
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}