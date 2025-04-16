
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Characters"."BaseCharacterData"]
    /// [Tstd2.Manager.TagResource]=>[CloneableObject]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000254U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [66, 97, 115, 101, 67, 104, 97, 114, 97, 99, 116, 101, 114, 68, 97, 116, 97])]
    
                
    // class 0x10 System.String tag
     [MonoCollectorSearchFieldAttribute(typeof(PMonoString),"tag", "TAG")]
            
    // struct 0x18 System.Int32 id
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"id", "ID")]
            
    // struct 0x1C System.Int32 lv
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"lv", "LV")]
            
    // struct 0x20 System.Int32 maxHp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxHp", "MAX_HP")]
            
    // class 0x28 System.String model
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"model", "MODEL")]
            
    // enum 0x30 Tstd2.Framework.TerrainType terrainTypes
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Framework.TerrainType),"terrainTypes", "TERRAIN_TYPES")]
            
    // enum 0x34 Tstd2.Inventory.WeaponType weaponTypes
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Inventory.WeaponType),"weaponTypes", "WEAPON_TYPES")]
            
    // class 0x38 Tstd2.Framework.StatList stat
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"stat", "STAT")]
            
    // class 0x40 System.String[] equipmentIDs
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"equipmentIDs", "EQUIPMENT_I_DS")]
            
    // class 0x48 System.String generalBuffName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"generalBuffName", "GENERAL_BUFF_NAME")]
            
    // enum 0x50 Tstd2.Characters.Immunity immunityFlag
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Characters.Immunity),"immunityFlag", "IMMUNITY_FLAG")]
            
    // class 0x58 System.String skillName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillName", "SKILL_NAME")]
            
    // class 0x60 Tstd2.Characters.CharacterModelData modelData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"modelData", "MODEL_DATA")]
            
    // class 0x68 Tstd2.Battle.Buffs.GeneralBuff buffData
     [MonoCollectorSearchFieldAttribute(typeof(GeneralBuff.Ptr_GeneralBuff),"buffData", "BUFF_DATA")]
    public partial class BaseCharacterData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Characters";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115];

        //public const string Const_ClassName = "BaseCharacterData";
        //public static byte[] Static_ClassName { get; } = [66, 97, 115, 101, 67, 104, 97, 114, 97, 99, 116, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000254U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_BaseCharacterData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_BaseCharacterData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_BaseCharacterData obj) => obj._ptr;
            public static implicit operator bool(Ptr_BaseCharacterData obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Tstd2.Characters"."BaseCharacterData"]
        /// </summary>
        public partial class BaseCharacterData
        { 

            
            
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
            ///  extern nint CLONE ();

            
            /// <summary>
            ///   Tstd2.Battle.Buffs.GeneralBuff get_BuffData()
            /// </summary>
            /// <returns>class Tstd2.Battle.Buffs.GeneralBuff</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BuffData")]
            ///  extern nint GET_BUFF_DATA ();

            
            /// <summary>
            ///   Tstd2.Characters.CharacterModelData get_ModelData()
            /// </summary>
            /// <returns>class Tstd2.Characters.CharacterModelData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ModelData")]
            ///  extern nint GET_MODEL_DATA ();
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BaseCharacterData))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BaseCharacterData))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BaseCharacterData))]
            ///  extern void .CTOR_02 ();

            
            /// public static partial class Search_BaseCharacterData
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