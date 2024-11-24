
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."StatValue"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200037FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107], [83, 116, 97, 116, 86, 97, 108, 117, 101])]
    
                
    // enum 0x10 Tstd2.Framework.StatType type
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Framework.StatType),"type", "TYPE")]
            
    // struct 0x14 System.Int32 value
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"value", "VALUE")]
    public partial class StatValue
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Framework";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107];

        //public const string Const_ClassName = "StatValue";
        //public static byte[] Static_ClassName { get; } = [83, 116, 97, 116, 86, 97, 108, 117, 101];

        //public const uint Const_TypeToken = 0x0200037FU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_StatValue(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_StatValue(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_StatValue obj) => obj._ptr;
            public static implicit operator bool(Ptr_StatValue obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Tstd2.Framework"."StatValue"]
        /// </summary>
        public partial class StatValue
        { 

            
            
            /// <summary>
            ///   System.Boolean Equals(Tstd2.Framework.StatValue other)
            /// </summary>
            /// <param name="other">class Tstd2.Framework.StatValue</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
            ///  extern System.Boolean EQUALS (nint other);
            
            
            
            /// <summary>
            ///   System.Void .ctor(Tstd2.Framework.StatType type, System.Int32 value)
            /// </summary>
            /// <param name="type">enum Tstd2.Framework.StatType</param>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StatValue))]
            ///  extern void .CTOR_00 (Tstd2.Framework.StatType type, System.Int32 value);

            
            /// <summary>
            ///   System.Void .ctor(Tstd2.Framework.StatType type)
            /// </summary>
            /// <param name="type">enum Tstd2.Framework.StatType</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StatValue))]
            ///  extern void .CTOR_01 (Tstd2.Framework.StatType type);

            
            /// public static partial class Search_StatValue
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor(Tstd2.Framework.StatType type, System.Int32 value)
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Tstd2.Framework.StatType", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(Tstd2.Framework.StatType type)
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Tstd2.Framework.StatType");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}