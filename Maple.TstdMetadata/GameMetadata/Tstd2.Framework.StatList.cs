
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."StatList"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200038DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107], [83, 116, 97, 116, 76, 105, 115, 116])]


    //class 0x10 System.Collections.Generic.List<Tstd2.Framework.StatValue> stats
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<StatValue.Ptr_StatValue>), "stats", "STATS")]
    public partial class StatList
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Framework";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107];

        //public const string Const_ClassName = "StatList";
        //public static byte[] Static_ClassName { get; } = [83, 116, 97, 116, 76, 105, 115, 116];

        //public const uint Const_TypeToken = 0x0200038DU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_StatList(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_StatList(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_StatList obj) => obj._ptr;
            public static implicit operator bool(Ptr_StatList obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Framework"."StatList"]
    /// </summary>
    public partial class StatList
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Object Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   System.Int32 get_Count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Count")]
        ///  extern System.Int32 GET_COUNT ();



        /// <summary>
        ///   Tstd2.Framework.StatValue get_Item(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class Tstd2.Framework.StatValue</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_StatList))]
        ///  extern nint GET_ITEM_00 (System.Int32 index);


        /// <summary>
        ///   System.Int32 get_Item(Tstd2.Framework.StatType type)
        /// </summary>
        /// <param name="type">enum Tstd2.Framework.StatType</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_StatList))]
        ///  extern System.Int32 GET_ITEM_01 (Tstd2.Framework.StatType type);


        /// <summary>
        ///   System.Void set_Item(System.Int32 index, Tstd2.Framework.StatValue value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">class Tstd2.Framework.StatValue</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item", Search = typeof(Search_StatList))]
        ///  extern void SET_ITEM_00 (System.Int32 index, nint value);


        /// <summary>
        ///   System.Void set_Item(Tstd2.Framework.StatType type, System.Int32 value)
        /// </summary>
        /// <param name="type">enum Tstd2.Framework.StatType</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item", Search = typeof(Search_StatList))]
        extern void SET_ITEM_01(StatType type, System.Int32 value);


        public static partial class Search_StatList
        {
            /// 
            ///     

            /// <summary>
            ///   Tstd2.Framework.StatValue get_Item(System.Int32 index)
            /// </summary>
            /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_Item(Tstd2.Framework.StatType type)
            /// </summary>
            /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "Tstd2.Framework.StatType");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_Item(System.Int32 index, Tstd2.Framework.StatValue value)
            /// </summary>
            /// public static bool SET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_Item", "System.Int32", "Tstd2.Framework.StatValue");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_Item(Tstd2.Framework.StatType type, System.Int32 value)
            /// </summary>
            public static bool SET_ITEM_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_Item", "Tstd2.Framework.StatType", "System.Int32");
            ///     
            ///  
            /// 
            /// 
        }

    }


}