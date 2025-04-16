
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Battle.Buffs"."GeneralBuffData"]
    /// [Tstd2.Battle.Buffs.ValueBattleBuffData]=>[Tstd2.Battle.Buffs.BattleBuffData]=>[Tstd2.Battle.Buffs.BuffData]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000359U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 117, 102, 102, 115], [71, 101, 110, 101, 114, 97, 108, 66, 117, 102, 102, 68, 97, 116, 97])]
    
                
    // struct 0x10 System.Boolean ourSide
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"ourSide", "OUR_SIDE")]
            
    // struct 0x14 System.Int32 resetTurn
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"resetTurn", "RESET_TURN")]
            
    // struct 0x18 System.Int32 randomAddTurn
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"randomAddTurn", "RANDOM_ADD_TURN")]
            
    // enum 0x1C Tstd2.Battle.Buffs.RestNumsBattleBuff restType
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Battle.Buffs.RestNumsBattleBuff),"restType", "REST_TYPE")]
            
    // class 0x20 System.Collections.Generic.List<System.Int32> values
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"values", "VALUES")]
            
    // enum 0x28 Tstd2.Battle.Buffs.ValueBuffType type
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Battle.Buffs.ValueBuffType),"type", "TYPE")]
            
    // struct 0x2C System.Single value
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"value", "VALUE")]
            
    // enum 0x30 Tstd2.Battle.Buffs.BuffCalcType calcType
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Battle.Buffs.BuffCalcType),"calcType", "CALC_TYPE")]
            
    // struct 0x34 System.Int32 turnProbability
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"turnProbability", "TURN_PROBABILITY")]
            
    // class 0x38 System.String shareRoleID
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"shareRoleID", "SHARE_ROLE_ID")]
            
    // struct 0x40 System.Boolean isTeam
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isTeam", "IS_TEAM")]
            
    // enum 0x44 Tstd2.Battle.Buffs.BuffActivePosition activePosition
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Battle.Buffs.BuffActivePosition),"activePosition", "ACTIVE_POSITION")]
    public partial class GeneralBuffData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Battle.Buffs";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 117, 102, 102, 115];

        //public const string Const_ClassName = "GeneralBuffData";
        //public static byte[] Static_ClassName { get; } = [71, 101, 110, 101, 114, 97, 108, 66, 117, 102, 102, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000359U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GeneralBuffData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GeneralBuffData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GeneralBuffData obj) => obj._ptr;
            public static implicit operator bool(Ptr_GeneralBuffData obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Tstd2.Battle.Buffs"."GeneralBuffData"]
        /// </summary>
        public partial class GeneralBuffData
        { 

            
            
            /// <summary>
            ///   System.Int32 get_GenerateRestTurn()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GenerateRestTurn")]
            ///  extern System.Int32 GET_GENERATE_REST_TURN ();
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuffData))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuffData))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuffData))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuffData))]
            ///  extern void .CTOR_03 ();

            
            /// public static partial class Search_GeneralBuffData
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

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}